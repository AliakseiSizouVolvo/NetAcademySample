namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport tesla = new Car();
            Transport plane = new Aircraft();
            Transport cruiseShip = new Ship();

            tesla.Move();
            plane.Move();
            cruiseShip.Move();
        }
    }
}
