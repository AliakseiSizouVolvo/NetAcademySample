namespace Interfaces;

public interface IMovable
{
    public float FuelConsumption { get; set; }
    public const double MaxSpeed = 30000000000;
    public void Move(int distance);
}


//public interface IBaseEntity