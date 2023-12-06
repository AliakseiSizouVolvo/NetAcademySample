namespace Exceptions;

public class MyAmazingCustomException : Exception
{
    public string SomeValue { get; set; }

    public MyAmazingCustomException (string someValue, 
        string message, Exception innerEx) 
        : base(message, innerEx)
    { }
    
}