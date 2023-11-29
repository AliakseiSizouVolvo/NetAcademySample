namespace MethodOverridingAndHiding;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DoSmth()
    {
        Console.WriteLine("I do smth");       
    }
}

public class Employee : Person
{
    public string CompanyName { get; set; }

    public void DoSmth()
    {
        Console.WriteLine($"Do some work for {CompanyName}");
    }
}