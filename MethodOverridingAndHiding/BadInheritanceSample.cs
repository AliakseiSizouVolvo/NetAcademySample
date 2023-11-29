namespace MethodOverridingAndHiding;

//NOT DO LIKE THAT EVER

public class Rectangle
{

    public int A { get; set; }
    public int B { get; set; }

    public Rectangle(int a, int b)
    {
        A =a; 
        B = b;
    }
    public long  P => (A+B) * 2;

    public long S => A * B;
}

public class Sqaure : Rectangle
{
    public Sqaure(int a, int b) 
        : base(a, b)
    {
        A = a;
        B = a;
    }
}