namespace MethodOverridingAndHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle()
            {
                LenghtA = 3,
                LenghtB = 4,
                LenghtC = 6,
            };
            Console.WriteLine($"Triangle A={triangle.LenghtA}, B={triangle.LenghtB}, C={triangle.LenghtC}, P = {triangle.CalculatePerimeter()}, S = {triangle.CalculateArea()}");

            var rTriangle = new RightTriangle()
            {
                LenghtA = 3,
                LenghtB = 4,
                LenghtC = 5,
            };
            Console.WriteLine($"Triangle A={rTriangle.LenghtA}, B={rTriangle.LenghtB}, C={rTriangle.LenghtC}, P = {rTriangle.CalculatePerimeter()}, S = {rTriangle.CalculateArea()}");

            TestClassA tca = new TestClassA();
            TestClassB tcB = new TestClassB();
            TestClassA tcBA = new TestClassB();//take as a base class

            tca.DoSmth();//A
            tcB.DoSmth();//B
            tcBA.DoSmth();//B



            ////BAD PRACTICE SAMPLE
            //Rectangle sqare = new Sqaure(2, 3);
            //sqare.S


            var p = new Person();
            p.DoSmth(); // do smth

            var e = new Employee() { CompanyName = "Volvo" };
            e.DoSmth(); // volvo

            Person pe = new Employee() { CompanyName = "Volvo" };
            pe.DoSmth(); // base logic
            (pe as Employee).DoSmth(); //volvo

            //hiding or shadowing
            var fish = new Fish();
            fish.SaySmth();

            var shark = new Shark();
            shark.SaySmth();

            Fish sharkFish = new Shark();
            sharkFish.SaySmth();
            (sharkFish as Shark).SaySmth();

            IInterface2 stc = new SomeTestClass();
            stc.Do();
        }
    }
}
