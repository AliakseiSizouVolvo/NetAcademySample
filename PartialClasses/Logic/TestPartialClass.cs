namespace PartialClasses;

public partial class TestPartialClass
{
    public int Property1 { get; set; }
    public int Property2 { get; set; }
    public int Property3 { get; set; }

    public partial void DoSmthElse();
    partial void DoSmthElseInternally();
}