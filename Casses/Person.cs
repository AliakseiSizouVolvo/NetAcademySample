namespace Classes
{
    public class Person
    {
        private bool _isAlive;

        public string EyeColor { get; }

        private int _smth;
        public int Smth
        {
            set
            {
                if (value > 0 && value < 100)
                {
                   Console.WriteLine("Positive");
                   _smth = value;

                }
                else
                {
                    Console.WriteLine("Negative not allowed");
                }
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }
        //public DateTime BirthDate;
        public string SomeValue { get; private set; }

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
            }
        }

        public Person()
        {
            EyeColor = "Random";
            SomeValue = "123";
        }
        //if uncomment - default constructor will not work
        //public Person(string name)
        //{
        //    Name = name;
        //}

        void Do()
        {
            SomeValue = "1";
        }
    }
}
