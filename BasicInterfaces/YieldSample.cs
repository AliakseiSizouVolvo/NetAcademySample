using System.Collections;

namespace BasicInterfaces;

public class YieldSample
{
    
}


public class Numbers :IEnumerable<int>
{
    private List<int> _numbers;

    public Numbers(List<int> numbers)
    {
        _numbers = numbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return i * i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}