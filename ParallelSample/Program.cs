namespace ParallelSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new List<Cat>()
            {
                new Cat(){Name = "Cat1", Color = "Brown"},
                new Cat(){Name = "Cat2", Color = "Brown"},
                new Cat(){Name = "Cat24", Color = "Brown"},
                new Cat(){Name = "Cat33", Color = "Brown"},
                new Cat(){Name = "Cat15", Color = "Brown"},
                new Cat(){Name = "Cat0", Color = "Brown"}
            };

            var orderedCats = cat
                .OrderBy(cat1 => cat1.Name)
                .ToList();

            var numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            var sqares = numbers
                .AsParallel()
                .AsOrdered()
                .Select(n => Square(n))
                //.OrderBy(i => i)
                .ToArray();

            sqares.AsParallel().ForAll(x=>
                Console.WriteLine(x));

            Parallel.For(0, orderedCats.Count, (i) =>
            {
                orderedCats[i].Name = "";
            });

            Parallel.ForEach(orderedCats, (cat) =>
            {
                Console.WriteLine(cat.Name);
            });
        }

        static int Square(int x) => x * x;
    }


}
