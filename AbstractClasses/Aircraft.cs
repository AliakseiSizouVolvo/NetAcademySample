namespace AbstractClasses;

public class Aircraft : Transport
{
    private void Fly()
    {
        Console.WriteLine("Flying");
    }

    public override void Move()
    {
        Fly();
    }
}