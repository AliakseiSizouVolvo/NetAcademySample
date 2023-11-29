namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = (10, 5);
            var tuple2 = (10, "str");
            var tuple3 = (10, "str",1,1,1,1,1,11);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2.Item1);
            Console.WriteLine(tuple2.Item2);

            (string, int, int) value = ("", 0 , 0);

            //var tupleAsClassInstance = new Tuple<int, int, int>(0,0,0);
        }

        public static (int,int) Do((string,string) tuple)
        {
            int.TryParse(tuple.Item1, out int firstValue);
            int.TryParse(tuple.Item2, out int secValue);

            return (firstValue, secValue);
        }
    }
}
