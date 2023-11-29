namespace MethodOverridingAndHiding;

public abstract class TestAbstractClass
{
    public abstract void DoSmth ();
}

public class TestClassA : TestAbstractClass
{
    public override void DoSmth()
    {
        Console.WriteLine("TestClassA");
    }

}

public class TestClassB : TestClassA
{
    public override void DoSmth()
    {
        Console.WriteLine("TestClassB");
    }

}