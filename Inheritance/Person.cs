namespace Inheritance;

public class Person
{
    public string FullName { get; set; }

    public string Address { get; set; }

    public string Contact { get; set; }

    public Person(string fullName, string address, string contact)
    {
        FullName= fullName;
        Address= address; 
        Contact= contact;
    }
    public void JustLiveLife()
    {
        Console.WriteLine("Live life");
    }

}