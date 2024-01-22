namespace ThreadsSample;

public class SemaphoreSample
{
    public static void Test()
    {
        for (int i = 0; i < 10; i++)
        {
            Visitor visitor = new Visitor(i);
        }
    }
}