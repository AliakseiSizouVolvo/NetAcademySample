using System.Collections;

namespace Generics;

public class GenericPossibilitiesSample<T, TY> //, K, P>
     where T : class, IDisposable, IEnumerable
     where TY : struct
{
    public  T Id { get; set; }
    //public K Smth { get; set; }
    public TY SmthElse { get; set; }
    //public P SomeData { get; set; }

    //public T DoSmth(out TY ty)
    //{

    //}
}