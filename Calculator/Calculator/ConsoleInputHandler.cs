namespace Calculator;

public class ConsoleInputHandler 
{
    private void PrintWarningMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private double GetDoubleValueFromConsole()
    {
        var isSucceed = false;
        while (!isSucceed)
        {
            Console.WriteLine("Please enter real value for operation");
            isSucceed = double.TryParse(Console.ReadLine(), out var result);
            if (isSucceed)
            {
                return result;
            }
            PrintWarningMessage("Entered value is incorrect, try again");
        }

        return double.NaN;
    }

    public Operation GetOperation(bool isNotFirstTry = false)
    {
        if (isNotFirstTry)
        {
            PrintWarningMessage("Incorrect input for operation. Try again.");
        }
        Console.WriteLine(
            $"Please enter an operation. Possible option: {Environment.NewLine}\t+ for adding,{Environment.NewLine}\t- for subtraction,{Environment.NewLine}\t* for multiplying,{Environment.NewLine}\t/ for dividing,{Environment.NewLine}\t^ for exponentiation,{Environment.NewLine}\t ! for factorial");

        var operationInput = Console.ReadLine();

        //Used mostly for shorter version of writing
        //You can find more https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching
        return operationInput switch
        {
            "+" => Operation.Addition,
            "-" => Operation.Subtraction,
            "*" => Operation.Multiplication,
            "/" => Operation.Division,
            "^" => Operation.Exponentiation,
            "!" => Operation.Factorial,
            _ => GetOperation(true)
        };
    }

    public (double, double) GetTwoOperands(Operation operation)
    {
        double secondOperand;
        var firstOperand = GetDoubleValueFromConsole();

        if (operation == Operation.Division)
        {
            bool isZero;
            do
            {
                secondOperand = GetDoubleValueFromConsole();
                isZero = secondOperand == 0;
                if (isZero)
                {
                    PrintWarningMessage("Divide by zero is not allowed");
                    Console.WriteLine("Please, try to enter value again");
                }
            } while (isZero);
        }
        else
        {
            secondOperand = GetDoubleValueFromConsole();
        }

        return (firstOperand, secondOperand);
    }

    public uint GetNonNegativeIntValue()
    {
        while (true)
        {
            Console.WriteLine("Please enter correct non negative integer value for operation");
            if (uint.TryParse(Console.ReadLine(), out var result))
            {
                return result;
            }

            PrintWarningMessage("Incorrect value. Try again");
        }
    }
}