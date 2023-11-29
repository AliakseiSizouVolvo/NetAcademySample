namespace PartialClasses;

public partial class TestPartialClass
{
    public int Property4 { get; set; }

    public void Do(int x)
    {
        Console.WriteLine(x);
    }

    public partial void DoSmthElse()
    {
        Console.WriteLine("Hello there");
        DoSmthElseInternally();
    }
}