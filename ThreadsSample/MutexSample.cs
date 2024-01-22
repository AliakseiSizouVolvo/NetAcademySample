using System.Net.Sockets;

namespace ThreadsSample;

public class MutexSample
{
    public int X { get; set; }

    object locker = new object();
    Mutex mutex = new Mutex();

    public void Test()
    {
        for (int i = 0; i < 5; i++)
        {
            var th = new Thread(PrintWithMutex);
            th.Name = $"Thread {i}";
            th.Start(); 
        }
    }

    public void PrintWithMutex()
    {
        mutex.WaitOne(); // thread stops till get mutex
        X = 1;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(X);
            X++;

        }
        mutex.ReleaseMutex();
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