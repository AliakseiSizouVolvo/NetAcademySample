namespace MethodOverridingAndHiding;

public class SomeTestClass : IInterface1, IInterface2
{
    void IInterface1.Do()
    {
        Console.WriteLine("Interface1");
    }

    void IInterface2.Do()
    {
        Console.WriteLine("Interface2");
    }
}