using System.Collections;

namespace BasicInterfaces;

public class PlantEnumerator : IEnumerator<Plant>
{
    private Plant _current;

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    Plant IEnumerator<Plant>.Current => _current;

    public object Current { get; }
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}