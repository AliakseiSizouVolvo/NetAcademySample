namespace AbstractClasses;

public class Car : Transport
{
    private void ConsumeFuel()
    {
        Console.WriteLine("Consume Fuel");
    }

    public override void Move()
    {
        ConsumeFuel();
    }
}