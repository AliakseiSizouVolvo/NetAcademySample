namespace AbstractClasses;

public class Car : Transport
{
    private void ConsumeFuel()
    {
        Console.WriteLine("Consume Fuel");
    }

    public override int SomeVariable { get; set; }

    public override void Move()
    {
        ConsumeFuel();
    }
}