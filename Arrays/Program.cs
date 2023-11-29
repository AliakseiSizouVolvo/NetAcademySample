namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int[] someNumbers = new int[10];

            numbers = new int[4] { 1, 2, 15, 100 };
            numbers = new int[] { 1, 2, 15, 100 };
            numbers = new[] { 1, 2, 15, 100 };
            int[] numbers2 = { 1, 2, 15, 100 };

            string[] fruits = { "Apple", "Peach", "Orange" };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(fruits[2]);

            numbers[0] = 1000;
            Console.WriteLine(numbers[0]);

            var numberLength = numbers.Length;
            Console.WriteLine(numberLength);

            var lastNumber = numbers[numberLength - 1];

            for (int i = 0; i < numberLength; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            int[,,] threeDimensionArray =
            {
                {
                    { 0, 1, 2 }, { 3, 4, 5 }
                },
                {
                    { 3, 4, 5 }, { 6, 7, 8 }
                }
            };
            var rows = threeDimensionArray.GetLength(0);
            var columns = threeDimensionArray.GetLength(1);
            var height = threeDimensionArray.GetLength(2);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < height; k++)
                    {
                        Console.WriteLine(threeDimensionArray[i, j, k]);
                    }

                }
            }

            //jagged arrays
            var arrayOfArrays = new int[][]
            {
                new[] { 1, 2, 3, 4, 5 },
                new[] { 5, 6, 7 },
                new[] { 8, 9, 10, 11, 16, 19, 15, 13 },
            };

            //foreach (var array in arrayOfArrays)
            //{
            //    Console.WriteLine(array);
            //}
            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                for (int j = 0; j < arrayOfArrays[i].Length; j++)
                {
                    Console.Write(arrayOfArrays[i][j]);
                    Console.Write("\t |");
                }
                Console.Write("\n");
            }
        }
    }
}
