namespace Structs;

public struct Person
{
    public string FullName;
    public string Address;
    public int PostCode;
    public int Age { get; set; }

    public Person(string name)
    {
        FullName = name;
    }

    public void Do()
    {
        Console.WriteLine("Hello");
    }
}