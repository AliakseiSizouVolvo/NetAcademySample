namespace MethodOverridingAndHiding;

public class RightTriangle : Triangle
{
    private double _lenghtA;
    public override double LenghtA
    {
        get
        {
            Console.WriteLine("overrided property");
            return _lenghtA;
        }
        set
        {
            _lenghtA = value;
        }
    }

    public double Height
    {
        get
        {
            return LenghtB;
        }
    }

    public double BaseLine { get { return LenghtA; } }

    public override double CalculateArea()
    {
        Console.WriteLine(base.CalculateArea());

        Console.WriteLine("Right triangle calculation");
        return Height * BaseLine / 2;
    }
}