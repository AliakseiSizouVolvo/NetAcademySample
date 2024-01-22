namespace DeadlockSample
{
    internal class Program
    {
        static object obj1 = new object();
        static object obj2 = new object();
        static void Main(string[] args)
        {

            StupidScenarioSample();
            var th1 = new Thread(Method1);
            var th2 = new Thread(Method2);

            th1.Start();
            th2.Start();

            Console.WriteLine("Hello there");

            th1.Join();
            th2.Join();
            Console.WriteLine("end");
        }

        static void Method1()
        {
            lock (obj1)
            {
                Console.WriteLine("Method 1");
                Thread.Sleep(1000);
                lock (obj2)
                {
                    Console.WriteLine("Method 1 second output");
                }
            }
        }

        static void Method2()
        {
            lock (obj2)
            {
                Console.WriteLine("Method 2");
                Thread.Sleep(1000);
                lock (obj1)
                {
                    Console.WriteLine("Method 2 second output");
                }
            }
        }

        static void StupidScenarioSample()
        {
            lock (obj1)
            {
                Console.WriteLine("Hello");
                lock (obj1)
                {
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}
