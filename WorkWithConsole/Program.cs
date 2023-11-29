namespace WorkWithConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var helloWorld = "Hello world";

            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(helloWorld);
            //Console.WriteLine("And Again");

            //var x = 1347;
            //Console.WriteLine("And some number:");
            //Console.WriteLine(x);

            //var isAlive = true;
            //Console.WriteLine(isAlive);

            //var name = "Bob";
            //Console.WriteLine("Some interesting will happen with next output");
            //Console.Write("Name of client: ");
            //Console.Write(name);
            //Console.WriteLine();

            //Console.WriteLine("This is 1st line \t This is 2nd");
            // \n - new line
            // \t 

            //Console.WriteLine("Hello" + Environment.NewLine + "World");

            Console.WriteLine("Provide your name:");
            var nameFromConsole = Console.ReadLine();

            Console.WriteLine("Hello, " + nameFromConsole);

            Console.WriteLine("Please type 1st number(x):");
            //var xIsNumber = int.TryParse(Console.ReadLine(), out var x);
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type 2nd number(y):");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x+y=");
            Console.WriteLine(x+y);
        }
    }
}