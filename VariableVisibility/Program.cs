namespace VariableVisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15;


            if (true)
            {
                x++;
                var z = 15;
            }

            //Console.WriteLine(z);
            for (int i = 0; i < 100; i++)
            {
                var y = 100;
                x++;
            }

            //Console.WriteLine(y);
        }
    }
}
