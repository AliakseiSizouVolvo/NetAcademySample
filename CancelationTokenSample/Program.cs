namespace CancelationTokenSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var t1 = new Task(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    if (i % 734==0)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Operation was canceled");
                        return;
                    }

                    Console.WriteLine(i);
                }
            }, cancellationToken);
            t1.Start();

            Thread.Sleep(1000);

            cts.Cancel();

            Thread.Sleep(1000);


            Console.WriteLine("Hello, World!");
            Console.WriteLine(t1.Status);
            cts.Dispose();

        }
    }
}
