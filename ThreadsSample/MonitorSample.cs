namespace ThreadsSample;

public class MonitorSample
{   
    public int X { get; set; }

    object locker = new object();


    public void Test()
    {
        for (int i = 0; i < 5; i++)
        {
            var th = new Thread(PrintWithMonitor);
            th.Start();
        }
    }

    private void PrintWithMonitor()
    {
        var isLocked = false;
        try
        {
            Monitor.Enter(locker, ref isLocked);

            Monitor.IsEntered(locker);
            Monitor.Pulse(locker);
            Monitor.PulseAll(locker);
            var result = Monitor.TryEnter(locker);

            var isReleased = Monitor.Wait(locker);
            X = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(X);
                X++;
            }
        }
        finally
        {
            if (isLocked) 
            {
                Monitor.Exit(locker);
            }
        }
    }
    private void PrintWithLock()
    {
        lock (locker)
        {
            X = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(X);
                X++;
            }
        }
    }
}