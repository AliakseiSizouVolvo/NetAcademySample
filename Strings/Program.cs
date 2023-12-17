namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cultureInfo = System.Globalization.CultureInfo.CurrentCulture;
            
            var sf = new StringFormatting();
            sf.FormatStringSample();

            string str1 = "blablabla";
            var str2 = "blablabla";

            var str3 = new string('a', 15);

            var str4 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });

            var str5 = new string(new char[] { 'w', 'o', 'r', 'l', 'd', }, 1, 3);


            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);

            var firstCharacter = str1[0];


            Console.WriteLine(str1.Length);

            foreach (var c in str2)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals(str2));

            //tricky comparing a strings
            var a = "asdas" + (char)847;//hidden symbol
            var b = "asdas";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);

            ///C# 11 (.Net 7)
            var text = """
                123123
                321312
                1231231
                123123123
                """;
            Console.WriteLine(text);

            var x = 1;
            var y = 15.5;

            var text2 = $"""
                Some calculation
                {x}
                willsfsdf;ldskfsdfks;dlfksl;
                sdfsdf
                sdf
                sdf
                sd
                {y}
            """;

            //concatination(shouldn't be used a lot)
            str1 = "Hello";
            str2 = "World";
            str3 = str1 + str2;//almost never use that
            str4 = string.Concat(str1, " ", str2);

            var list = new List<string>()
            {
                "Hello",
                "!",
                " What's up?",
                "See",
                "you",
                "later"
            };

            var result = string.Join(" ", list);
            Console.WriteLine(result);


            //comparison of strings
            var s1 = "hello";
            var s2 = "world";

            //if s1 before s2 in alphabet -> -1
            //same -> 0
            //else -> 1
            var comparisonResult = string.Compare(s1, s2);
            //equivalent for 
            s1.CompareTo(s2);


            //search in string
            s1 = "Hello World";
            //first index of substrings 

            var character = 'o';
            var index = s1.IndexOf(character);
            index = s1.IndexOf(character, StringComparison.InvariantCultureIgnoreCase);

            var lastIndex = s1.LastIndexOf(character);

            var isStartWith = s1.StartsWith("hello", StringComparison.CurrentCultureIgnoreCase);
            var isEndWith = s1.EndsWith("d");

            //split a string
            s1 = "We knew that it would happen in that way";
            var words = s1.Split(" ");
            var separators = new char[] {' ', ',', '.'};
            words = s1.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //trim

            str1 = " Hello world   ";
            str1 = str1.Trim();
            Console.WriteLine(str1);
            str1 = str1.Trim(new char[]{'d', 'H', });
            Console.WriteLine(str1);

            //insert 
            text = "helloworld";
            var substring = " ";

            text = text.Insert(5, substring);
            Console.WriteLine(text);

            //delete
            text = text.Remove(5);
            Console.WriteLine(text);

            text = text.Remove(0, 1);
            Console.WriteLine(text);

            //replace
            text = "It_was_a_pretty_cool_day";
            text = text.Replace("_", " ");
            text = text.Replace("day", "");

            //upper&lowercase 
            text = text.ToLowerInvariant();
            text = text.ToUpperInvariant();

            //text.Reverse()
        }
    }
}
