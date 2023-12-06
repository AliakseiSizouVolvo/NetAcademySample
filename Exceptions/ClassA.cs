namespace Exceptions;

public class ClassA
{
    public string HelloMessage { get; set; }
}

public class ClassB
{
    public ClassA A { get; set; }

    public string DoSmth()
    {
        var str = string.Empty;
        for (long i = 0; i < long.MaxValue; i++)
        {
            str += (str + i);
        }
        
        var str2 = string.Empty;
        for (long i = 0; i < long.MaxValue; i++)
        {
            str += i;
        }

        return str + str2;
    }
    public void Do()
    {
        var x = true;
        if (x)
        {
            Do();
        }
    }
}