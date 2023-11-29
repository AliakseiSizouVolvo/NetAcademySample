namespace Records;

public record class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public record class PersonWithPositionalSyntax(string Name, int Age);

public class User
{
    public string Name { get; init; }

    public User(string name)
    {
        Name = name;
    }

    
}
//public record struct PersonStruct
//{
//    public string Name { get; set; }

//    public PersonStruct(string name)
//    {
//        Name = name;
//    }
//}

public record Employee(string Name, int Age, string Company) : Person(Name, Age);