namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basic immutable sample;
            //string value = Console.ReadLine();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    value += i.ToString();
            //    //Console.WriteLine(value);
            //}

            //Console.WriteLine(value);

            var user1 = new User("Tom");
            var user2 = new User("Tom");
            if (user1.Equals(user2))
            {
                Console.WriteLine("true");
            }
            Console.WriteLine(user1);


            var person1 = new Person("Bob", 20);
            var person2 = person1 with {Age = 25};
            var person3 = new Person("Bob", 20);
            if (person1.Equals(person3))
            {
                Console.WriteLine("true");
            }


            var pPerson = new PersonWithPositionalSyntax("Positional Bob", 25);
            Console.WriteLine(person1);
            Console.WriteLine(pPerson);

            var (personAge, personName ) = pPerson;

            Console.WriteLine(personName);
            Console.WriteLine(personAge);

            var tuple = pPerson;
            //person.Name = "Tom";
        }
    }
}
