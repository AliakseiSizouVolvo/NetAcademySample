namespace AbstractClasses;

public class Aircraft : Transport
{
    private void Fly()
    {
        Console.WriteLine("Flying");
    }

    public override int SomeVariable { get; set; }

    public override void Move()
    {
        Fly();
    }
}