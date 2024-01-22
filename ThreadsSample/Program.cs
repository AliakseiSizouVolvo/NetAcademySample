namespace ThreadsSample
{
    //public delegate void ThreadStart();
    //public delegate void ParametrizedThreadStart(object? obj);
    public class Program
    {
        static void Main(string[] args)
        {
            SemaphoreSample.Test();

            //var sts = new SynchronizingThreadsSample();
            //sts.WorkWithList();
            //var currentThread = Thread.CurrentThread;

            //Console.WriteLine(currentThread.Name);
            //currentThread.Name = "Main method from sample";
            //Console.WriteLine(currentThread.Name);

            //Console.WriteLine(currentThread.IsAlive);
            //Console.WriteLine(currentThread.ManagedThreadId);
            //Console.WriteLine(currentThread.Priority);
            //Console.WriteLine(currentThread.ThreadState);


            //var thr1 = new Thread(Print);
            //thr1.Name = "Th #1";
            //var thr2 = new Thread(new ThreadStart(Print));
            //thr2.Name = "Th #2";

            //var thr3 = new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(
            //            $"Hello from {Thread.CurrentThread.Name}");
            //        //Thread.Sleep(300);
            //    }
            //});

            //thr3.Name = "Th #3";

            //thr1.Start();
            //thr2.Start();
            //thr3.Start();

            //Thread.Sleep(2000);

            //var pthr1 = new Thread(SayHello);
            //pthr1.Start("Hello");
        }


        static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello from {Thread.CurrentThread.Name}");
                //Thread.Sleep(500);
            }
        }

        static void SayHello(object? o)
        {
            Console.WriteLine($"Hello from {Thread.CurrentThread.Name} - {o}");
        }

        static void CalculateAsSeparatedThread(string s)
        {
            var th1 = new Thread(DirectCalculation);
            var stringVariable = "blablalba";
            th1.Start(stringVariable);
        }

        static void DirectCalculation(object? s)
        {
            var x = s as string;  
            {
                
            }
        }
    }
}
