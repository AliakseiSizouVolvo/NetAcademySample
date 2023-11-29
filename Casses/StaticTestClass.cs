namespace Classes;

public static class PhysicCalculator
{
    public static double GVariable;
    //public int TestField;
    public static int TestStaticField;

    //no access modifiers and no parameters
    static PhysicCalculator()
    {
        Console.WriteLine("Hello from static constr");
        GVariable = 9.8;
        TestStaticField = 0;
    }

    //public void Calculate()
    //{
    //    Console.WriteLine(TestField * GVariable);
    //}

    public static void CalculateForce(double mass)
    {
        Console.WriteLine(mass*GVariable);
    }
}