namespace ThreadsSample;

public class SynchronizingThreadsSample
{
    public int X { get; set; }

    public List<(string, int)> List { get; set; } =
        new List<(string, int)>();
    private object locker = new();
    public void Do()
    {
        X = 0;
        for (int i = 0; i < 5; i++)
        {
            var th = new Thread(PrintSmth);
            th.Name = $"Thread #{i}";
            th.Start();

        }


        //var th2 = new Thread(PrintSmth);
        //th2.Name = $"Thread #{2}";

        //th1.Join();
        //th2.Start();
        //th2.Join();



    }

    public void WorkWithList()
    {
        var th1 = new Thread(AddToListInThread);
        var th2 = new Thread(AddToListInThread);
        var th6 = new Thread(AddToListInThread);
        var th3 = new Thread(AddToListInThread);
        var th4 = new Thread(AddToListInThread);
        var th5 = new Thread(AddToListInThread);

        th1.Start();
        th2.Start();
        th3.Start();
        th4.Start();
        th5.Start();
        th6.Start();

    }
    private void PrintSmth()
    {
        lock (locker)
        {
            X = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - {X}");
                X++;
                Thread.Sleep(100);
            }
        }
    }

    private void AddToListInThread()
    {
        lock (locker)
        {
            for (int i = 0; i < 10000; i++)
            {
                List.Add((Thread.CurrentThread.Name, i));
            }
        }
    }


}