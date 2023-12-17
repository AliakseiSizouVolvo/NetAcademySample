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
        }
    }
}
