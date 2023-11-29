namespace Inheritance;

public class Employee : Person
{
    public string Accesses { get; set; }

    public Employee(string fullName, 
        string address, 
        string contact, 
        string accesses)
    : base(fullName, address, contact)
    {
        Accesses = accesses;
    }

    public void Work()
    {
        Console.WriteLine("Work");
    }

}