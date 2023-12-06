namespace Calculator;

public class ConsoleCalculatorMenuHandler
{
    private readonly ConsoleInputHandler _consoleHandler = new ConsoleInputHandler();

    private string HandleCalculation()
    {
        var operation = _consoleHandler.GetOperation();

        switch (operation)
        {
            case Operation.Addition:
            {
                var operands = _consoleHandler.GetTwoOperands(operation);
                return $"{operands.Item1} + {operands.Item2} = {Calculator.Add(operands.Item1, operands.Item2)}";
            }
            case Operation.Subtraction:
            {
                var operands = _consoleHandler.GetTwoOperands(operation);
                return $"{operands.Item1} - {operands.Item2} = {Calculator.Subtracts(operands.Item1, operands.Item2)}";
            }
            case Operation.Multiplication:
            {
                var operands = _consoleHandler.GetTwoOperands(operation);
                return $"{operands.Item1} * {operands.Item2} = {Calculator.Multiply(operands.Item1, operands.Item2)}";
            }
            case Operation.Division:
            {
                var operands = _consoleHandler.GetTwoOperands(operation);
                return $"{operands.Item1} / {operands.Item2} = {Calculator.Divide(operands.Item1, operands.Item2)}";
            }
            case Operation.Exponentiation:
            {
                var operands = _consoleHandler.GetTwoOperands(operation);
                return $"{operands.Item1} ^ {operands.Item2} = {Calculator.Exponent(operands.Item1, operands.Item2)}";
            }
            case Operation.Factorial:
            {
                var operand = _consoleHandler.GetNonNegativeIntValue();
                return $"{operand}! = {Calculator.CalculateFactorial(operand)}";
            }
            default:
            {
                return "Smth goes wrong";
            }
        }
    }

    public void HandleUserInput()
    {
        Console.WriteLine("Hello User. This is our calculator for your great experience. Please follow the instructions below:");

        while (true)
        {
            var output = HandleCalculation();
            Console.WriteLine(output);

            var isExit = ExitInput();
            if (isExit)
            {
                return;
            }
        }
    }

    private bool ExitInput()
    {
        Console.WriteLine("Do you want to try one more time? y/n");

        var input = Console.ReadLine();
        if (input.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            return true;
        
        if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            return false;
        
        return ExitInput();
    }
}