namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateConsoleMenu();
            var x = 0.1;
            BadRecursionExample(x);
        }

        static void CreateConsoleMenu()
        {
            Console.WriteLine("Please enter one of the following options: 1,2,3,4,5");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    break;

                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    CreateConsoleMenu();
                    break;
            }



        }


        static double BadRecursionExample(double x)
        {

            Console.WriteLine(x);
            x--;
            if (x!=1)
            {
                return BadRecursionExample(x);
            }
            else
            {
                return x;
            }
        }
    }
}
