namespace Interfaces;

public class Cat : IMovable
{
    public float FuelConsumption { get; set; }
    public void Move(int distance)
    {
        Console.WriteLine($"Cat run throw the flat. Distance was.{distance} You should feed it");
    }
}