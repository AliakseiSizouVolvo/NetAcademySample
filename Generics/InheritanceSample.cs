namespace Generics;

public class Person
{
    public string Name { get; set; }
}

public class Person<T> : Person where T : IDisposable
{
    public T Id { get; set; }
}

public class UniversalPeron<T> : Person<T> where T : IDisposable
    //where T : class
{

}