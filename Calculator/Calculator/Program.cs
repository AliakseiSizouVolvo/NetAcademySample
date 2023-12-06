namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleHandler = new ConsoleCalculatorMenuHandler();
            consoleHandler.HandleUserInput();
        }
    }
}
