namespace MethodOverridingAndHiding;

public class Fish
{
    public void SaySmth()
    {
        Console.WriteLine("Fish say nothing");
    }
}

public class Shark: Fish
{
    public new void SaySmth()
    {
        Console.WriteLine("Shark say nothing");
    }
}