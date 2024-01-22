namespace TaskExceptionSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task<long>(()=>Calculation(15, 0));
            var t2 = new Task(() => Do(new []{0,1,2}));

            t1.Start();
            t2.Start();

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }

            var result = t1.Result;
        }

        static long Calculation(int x, int y)
        {
            return x / y;
        }

        static void Do(int[] arr)
        {
            var elementIndex = arr.Length+1;
            var element = arr[elementIndex];
            Console.WriteLine(element);
        }
    }
}
