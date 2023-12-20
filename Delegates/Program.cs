using System.Text.Json;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var integers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Exensions.Predicate<int> predicate = IsSquare;

            var squares = Exensions.Filter(integers, predicate);

            Console.WriteLine(JsonSerializer.Serialize(squares));

            var evenNumbers = Exensions.Filter(integers, delegate (int val) { return val % 2 == 0; });

            Console.WriteLine(JsonSerializer.Serialize(evenNumbers));

            var oddNumbers = Exensions.Filter(integers, (val) => val % 2 == 1);

            Console.WriteLine(JsonSerializer.Serialize(oddNumbers));

            // here we are using Filter as an "Extension method".
            // It's the same as before, but the syntax is easier to read
            var numbersDivisibleBy3 = integers.Filter((val) => val % 3 == 0);

            Console.WriteLine(JsonSerializer.Serialize(numbersDivisibleBy3));

            // finally, this is how we do it with built-in methods of C#:
            Func<int, bool> predicate2 = (val) => val % 4 == 0;
            var numbersDivisibleBy4 = integers.Where(predicate2).ToArray();
            // or as inline
            numbersDivisibleBy4 = integers.Where((val) => val % 4 == 0).ToArray();

            Console.WriteLine(JsonSerializer.Serialize(numbersDivisibleBy4));

            // capturing a variable reference (may prevent garbage collection of value)
            string a = "before";
            Action<int> act = (i) => Console.WriteLine($"a is :{a}; i is :{i}");
            a = "after";

            act(10); // oops, we get "After!"
        }

        public static bool IsSquare(int val) => Math.Sqrt(val) % 1 == 0;
    }

    public static class Exensions
    {
        public delegate bool Predicate<T>(T obj);
        public static T[] Filter<T>(this T[] source, Predicate<T> predicate)
        {
            var result = new List<T>();
            foreach (var item in source) 
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
