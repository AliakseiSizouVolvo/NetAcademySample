using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "Hello, World! Some more words there. Hello and hello again";
            var regex = new Regex(@"he(\w*)");
            var regex2 = new Regex(@"(\w*)");


            var matchCollection = regex.Matches(s);
            var matchCollection2 = regex2.Matches(s);

            if (matchCollection2.Count > 0)
            {
                foreach (Match match in matchCollection2)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No matches");
            }

            ///////////////////////////////////////////////////////////////////////////////////

            var regexOptionalChar = new Regex(@"xlsx?");
            foreach (var fileExtension in new[] { "xls", "xlsx", "xml" })
            {
                Console.WriteLine($"File extension {fileExtension} mathes: {regexOptionalChar.IsMatch(fileExtension)}");
            }

            ///////////////////////////////////////////////////////////////////////////////////

            var nameMatchWithCapture = new Regex("(my name is (?<name>[a-zA-Z]+))|(they call me (?<name>[a-zA-Z]+))");
            var greetings = new[] 
            {
                "Hello, my name is Jane.",
                "Where i'm from they call me Jhon.",
                "Hi, nice to meet you!"
            };
            foreach (var greeting in greetings)
            {
                var match = nameMatchWithCapture.Match(greeting);
                var name = match.Groups["name"]?.Value;
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "not found";
                }
                Console.WriteLine($"Name: {name}");
            }

            //////////////////////////////////////////////////////////////////////////////////////

            var dateFormat1 = new Regex(@"\d{1,2}\\\d{1,2}\\\d{4}");

            var text = @"Please be informed, that the wedding of Samuel and Mary will be celebrated on 14\8\2024 at the Hampton Mannor.";

            var date = dateFormat1.Match(text).Groups[0];

            Console.WriteLine($"Matched date: {date}");
        }
    }
}
