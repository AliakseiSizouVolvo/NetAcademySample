namespace Calculator;

public static class Calculator
{
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Subtracts(double x, double y)
    {
        return x - y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        if (y==0)
        {
            return double.NaN;
        }
        return x / y;
    }

    public static double Exponent(double number, double power)
    {
        return Math.Pow(number, power);
    }
    
    public static ulong CalculateFactorial(uint x)
    {
        try
        {
            if (x == 0)
                return 1;

            ulong fact = 1;
            for (uint i = 1; i <= x; i++)
            {
                fact = checked(fact * i);
            }
            return fact;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }
}