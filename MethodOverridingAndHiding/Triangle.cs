namespace MethodOverridingAndHiding;

public class Triangle
{
    public virtual double LenghtA { get; set; }
    public double LenghtB { get; set; }
    public double LenghtC { get; set; }

    public virtual double CalculateArea()
    {
        Console.WriteLine("Base triangle calculation");

        var semiPerimiter = CalculatePerimeter() / 2;
        var area = Math.Sqrt((semiPerimiter * (semiPerimiter - LenghtA) * (semiPerimiter - LenghtB) *
                              (semiPerimiter - LenghtC)));
        return area;
    }

    public double CalculatePerimeter()
    {
        return LenghtA+LenghtB+LenghtC;
    }
}