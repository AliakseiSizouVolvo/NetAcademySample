namespace MethodOverridingAndHiding;

public class TestClass
{
    //method overloading
    public void DoSmth(int x)
    {
        Console.WriteLine(x);
    }

    public void DoSmth(string x)
    {
        Console.WriteLine(x);
    }

    public void DoSmth(int x, int y)
    {

    }

    public void DoSmth(int x, string y)
    {
        Console.WriteLine(x);
    }

    public void DoSmth(string y, int x )
    {
        Console.WriteLine(x);
    }
}