namespace BasicExceptionSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                if (y ==0)
                {
                    //do some warning
                }
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception was faced");
                Console.WriteLine(ex.Message);
                Console.Write("try again");
            }
            Console.WriteLine("hello there");

        }
    }
}
