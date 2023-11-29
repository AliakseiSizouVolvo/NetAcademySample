using Classes;

namespace Casses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cat = new Cat();
            //cat.Name = "Test";
            //var cat1 = new Cat("Catname #1", "Grey");
            //cat1.Name = "Catname#15";
            //var cat2 = new Cat("Catname #2", "Brown");
            //var cat3 = new Cat( "Different colors");
            //var cat4 = new Cat("Catname #4", "Black");
            
            ////readonly fields 
            //var brownCat = new Cat("Brown");
            //brownCat.Name = "Some name";
            ////brownCat.Color = "Black";
            //Console.WriteLine(brownCat.Color);

            ////access modifiers:
            //var testCat = new Cat("TestName", "TetsColor", 7);
            ////public - public accessable from anywhere
            //testCat.Name = "New Test Cat Name";
            ////private - not accessable here
            ////testCat._age


            ////Console.WriteLine(cat.Name);

            //cat1.PrintInfo();
            //cat2.PrintInfo();
            //cat3.PrintInfo();
            //cat4.PrintInfo();


            var person = new Person()
            {
                Name = "Bob",
                IsAlive = true,
                Age = 30,
                //BirthDate = new DateTime(1990,10,19)
            };

            //static sample
            PhysicCalculator.TestStaticField = 15;
            //var testStaticObj1 = new PhysicCalculator()
            //{
            //    TestField = 1
            //};
            //var testStaticObj2 = new PhysicCalculator()
            //{
            //    TestField = 2,
            //};
            //testStaticObj2.Calculate();
            //testStaticObj1.Calculate();
            PhysicCalculator.GVariable = 5;
            //testStaticObj2.Calculate();
            //testStaticObj1.Calculate();

            PhysicCalculator.CalculateForce(10);
        }
    }
}
