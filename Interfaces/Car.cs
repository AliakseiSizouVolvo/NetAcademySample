namespace Interfaces;

public class Car : IMovable
{
    public float FuelConsumption { get; set; }
    public void Move(int distance)
    {
        Console.WriteLine($"Car goes on {distance}. Amount of consumed fuel = {distance * FuelConsumption}");
    }
}