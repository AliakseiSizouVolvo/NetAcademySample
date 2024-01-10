namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one option");
            var fruitChoice = Menu.GetUserChoice(
                allowCancel: false,
                MenuOption<string>.FromStringWithShortcutChar("Red [A]pple", "Apple"),
                MenuOption<string>.FromStringWithShortcutChar("Juicy [O]range", "Orange"),
                MenuOption<string>.FromStringWithShortcutChar("Tasty [B]anana", "Banana"));

            Console.WriteLine($"You chose {fruitChoice}");

            Console.WriteLine("What do you want to do?");
            var actionChoice = Menu.GetUserChoice(
                allowCancel: true,
                new MenuOption<Action>("Eat it", () => Console.WriteLine($"You eat the {fruitChoice}")),
                new MenuOption<Action>("Gift it", () => Console.WriteLine($"You gift the {fruitChoice}")),
                new MenuOption<Action>("Sleep", Dance));

            if (actionChoice != null)
            {
                actionChoice();
            }

            //var integer = Menu.GetUserInput(
            //    "Please enter int.",
            //    inputRegex: Menu.integerRegex.Value);

            //Console.WriteLine($"You entered {integer}");

            //var dec = Menu.GetUserInput(
            //    "Please enter decimal.",
            //    inputRegex: Menu.decimalRegex.Value);

            //Console.WriteLine($"You entered {dec}");
        }

        public static void Dance()
        {
            Console.WriteLine("You put it away and have some sleep.");
        }
    }
}
