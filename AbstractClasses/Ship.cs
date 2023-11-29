namespace AbstractClasses;

public class Ship : Transport
{
    private int _smth;
    private void Cruise()
    {
        Console.WriteLine("Cruise");
    }

    public override void Move()
    {
        Cruise();
    }

    public override int SomeVariable
    {
        get
        {
            Console.WriteLine("Hello from getting value");
            return _smth;
        }
        set
        {
            _smth = value;
        }
    }
}