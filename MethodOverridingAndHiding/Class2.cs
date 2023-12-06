namespace MethodOverridingAndHiding;

public class Class2  : IInterface1
{
    public virtual void Do()
    {
        throw new NotImplementedException();
    }
}

public class Class3 : Class2
{

}

public class Class4 : Class3
{

}

public class Class5 : Class4
{
    public sealed override void Do()
    {
        Console.WriteLine("Final Version");
    }
}

public class Class6 : Class5
{
    //public override void Do();
}