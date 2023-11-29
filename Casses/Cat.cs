namespace Classes
{
    public class Cat
    {
        public string Name="";
        public readonly string Color = "Some color";
        
        private int _age;

        public Cat(){}

        public Cat(string color)
        {
            Color = color;
        }

        public Cat(string name, string color) 
            : this(color) 
        {
            Name = name;
        }

        public Cat(string name, string color, int age) 
            : this(name, color)
        {
            _age = age;
        }

        public void PrintInfo()
        {
            //Console.WriteLine("Cat info. Name:"+Name + " Color:"+Color);
            Console.WriteLine($"Cat info. {Environment.NewLine}Name: {Name} {Environment.NewLine}Color: {Color} {Environment.NewLine}Age:{_age}");
        }
    }
}
