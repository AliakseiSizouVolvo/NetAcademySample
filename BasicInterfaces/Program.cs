namespace BasicInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var object1 = new object();
            

            var cat1 = new Cat()
            {
                Name = "Cat 1",
                Color = "Brown"
            };
            var cat2 = new Cat()
            {
                Name = "Cat 1",
                Color = "Brown"
            };
            var cat3 = cat1;
            var cat4 = new Cat()
            {
                Name = "Cat 4",
                Color = "Black"
            };
            var cat5 = new Cat()
            {
                Name = "Cat 1",
                Color = "Brown"
            };

            //Console.WriteLine(cat1 > cat5);
            Console.WriteLine(cat1 == cat2);
            Console.WriteLine(cat1 == cat3);

            var list = new List<Cat>()
            {
                cat1,
                cat2,
                cat3,
                cat4,
                cat5,
            };

            list.Sort(new CatComparer());

            Console.WriteLine(cat2.Equals(cat3));



            //var farm = new Farm(
            //    new List<Plant>()
            //    {
            //        new Plant()
            //        {
            //            Id = 1,
            //            Name = "Strawberry",
            //            Type = " Berries",
            //            State = "Alive"
            //        },
            //        new Plant()
            //        {
            //            Id = 2,
            //            Name = "Apple",
            //            Type = " Tree",
            //            State = "Alive"
            //        }
            //    });



            ////    new Dictionary<int, Plant>()
            ////{
            ////    {1, new Plant()
            ////    {
            ////        Id = 1, 
            ////        Name = "Strawberry",
            ////        Type = " Berries",
            ////        State = "Alive"
            ////    }},
            ////        {2, new Plant()
            ////        {
            ////            Id = 2,
            ////            Name = "Apple",
            ////            Type = " Tree",
            ////            State = "Alive"
            ////        }}
            ////});

            //foreach (var plant in farm)
            //{
            //    Console.WriteLine($"{plant.Name} - {plant.State}");
            //}

            var collection = new List<int>()
            {
                1, 2, 3, 4
            };

            var numbers = new Numbers(collection);

            GetValues(numbers);

        }

        public static int GetValues(Numbers x)
        {
            foreach (var el in x)
            {
                Console.WriteLine(el);

            }
            return 0;

        }
    }
}

