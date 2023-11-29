namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var person = new Person("abc");

           Console.WriteLine(person.PostCode);
            person.Do();

            int x = 0;
        }
    }
}
