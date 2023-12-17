using System.Text;


namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long.TryParse(Console.ReadLine(), out long n);

            var x = Print(n);
        }

        static string Print(long n)
        {
            var str = "1234567890123456";
            var sb = new System.Text.StringBuilder(str, 100000);

            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.MaxCapacity);




            for (var i = 0l; i < n; i++)
            {
                sb.Append(i);
            }

            //sb.Insert()
            str = sb.ToString();
            return str;
        }
    }
}
