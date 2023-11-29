namespace AbstractClasses;

public abstract class Transport
{
    public abstract int SomeVariable { get; set; }
    public int Weight { get; set; }
    public abstract void Move();
}