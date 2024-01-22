namespace CommonMistakesWithMultiThreading;

public class LockBestPracticesSample
{
    private int _locker;
    //public static object smth = new object();
    public void WriteToSmth()
    {
        Monitor.Enter(_locker);
        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Monitor.Exit(_locker);
        }
        //lock (_locker)
        //{
            
        //}
    }

    public void DoSmth()
    {
        lock (this)
        {
            
        }
    }
}