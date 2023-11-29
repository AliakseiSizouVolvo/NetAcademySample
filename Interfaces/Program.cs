namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();

            IMovable cat2 = new Cat();
            IMovable car = new Car();
            IMovable movableObj = cat;

            if (cat2 is Cat cat3)
            {
                //cat3 = cat2 as Cat; equivalent
            }
            
            var catCar = car as  Cat;//null

        }
    }
}
