namespace ThreadsSample;

public class Visitor
{
    private static Semaphore _semaphore = new Semaphore(3, 3);

    private Thread _visitorThread;
    private int _count = 5;

    public Visitor(int i)
    {
        _visitorThread = new Thread(Visit);
        _visitorThread.Name = $"Visitor {i}";
        _visitorThread.Start();
    }

    private void Visit()
    {
        while (_count>0)
        {
            _semaphore.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} come");
            Console.WriteLine($"{Thread.CurrentThread.Name} sit");
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} leave");
            _semaphore.Release();

            _count--;
            Thread.Sleep(1000);

        }
    }
}