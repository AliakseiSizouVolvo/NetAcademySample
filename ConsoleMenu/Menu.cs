using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class MenuOption<T>
    {
        public string Text { get; init; }
        public char? Shortcut { get; init; }
        public T Payload { get; init; }

        public MenuOption(
            string text,
            char? shortcut,
            T payload) 
        {
            this.Text = text;
            this.Shortcut = shortcut;
            this.Payload = payload;
        }

        public MenuOption(
            string text,
            T payload): this(text, null, payload)
        {

        }

        /// <summary>
        /// Takes string like "[C]argo Vehicle",
        /// highlights character C and uses it shortcut
        /// </summary>
        /// <param name="text"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static MenuOption<T> FromStringWithShortcutChar(
            string text,
            T payload)
        {
            int start = text.IndexOf('[');
            var shortcut = text[start + 1];
            var textWithHighlight = text.Replace("[", "\x1b[91m").Replace("]", "\x1b[39m");

            return new MenuOption<T>(textWithHighlight, shortcut, payload);
        }
    }

    public static class Menu
    {
        public static T GetUserChoice<T>(
            bool allowCancel = false,
            params MenuOption<T>[] options)
        {
            var duplicates = options
                                .Where(x => x.Shortcut != null)
                                .GroupBy(x => x.Shortcut.Value)
                                .Where(x => x.Count() > 1)
                                .ToList();

            if (duplicates.Any())
            {
                throw new ArgumentException($"Found multiple options with same shortcut: {JsonSerializer.Serialize(duplicates)}");
            }

            while (true)
            {
                if (TryGetUserChoice(out T val))
                {
                    return val;
                }
            }
            
            bool TryGetUserChoice(out T val)
            {
                foreach (var (option, index) in options.Select((option, index) => (option, index)))
                {
                    Console.WriteLine($"{index + 1} - {option.Text}");
                }

                if (allowCancel)
                {
                    Console.WriteLine("Or type 'cancel'.");
                }

                var input = GetUserInput().ToLowerInvariant();

                if (allowCancel && input == "cancel")
                {
                    val = default(T);
                    return true;
                }

                if (int.TryParse(input, out int i)
                    && i > 0
                    && i <= options.Length)
                {
                    val = options[i - 1].Payload;
                    return true;
                }

                if (input.Length == 1)
                {
                    var choice = char.ToUpperInvariant(input[0]);
                    var choiceByShortcut = options.Where(x => x.Shortcut.HasValue && char.ToUpperInvariant(x.Shortcut.Value)  == choice).SingleOrDefault();
                    if (choiceByShortcut != null)
                    {
                        val = choiceByShortcut.Payload;
                        return true;
                    }
                }

                Console.WriteLine("Could not recognize chocice");
                val = default(T);
                return false;
            }
        }

        public static Lazy<Regex> integerRegex = new Lazy<Regex>(() => new Regex("^-?\\d+$"));
        public static Lazy<Regex> decimalRegex = new Lazy<Regex>(() => new Regex("(^-?\\d+$)|(^-?\\d+[,.]\\d+$)"));

        public static string GetUserInput(
            string promptText = null,
            string onErrorText = "Please try again",
            Regex? inputRegex = null)
        {
            if (promptText != null) 
            {
                Console.WriteLine(promptText);
            }
            
            while (true)
            {
                var input = Console.ReadLine()?.Trim() ?? "";
                if (inputRegex == null
                    || inputRegex.IsMatch(input))
                {
                    return input;
                }
                Console.WriteLine(onErrorText);
            }
        }
    }
}
