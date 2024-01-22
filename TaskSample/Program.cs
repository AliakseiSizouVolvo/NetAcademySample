namespace TaskSample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var outerTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello from outer task");
                var innerTask = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Hello from inner task");
                    Thread.Sleep(2000);
                    Console.WriteLine("inner task finished");
                }, TaskCreationOptions.AttachedToParent);
                Console.WriteLine("outer task finished");
            }, TaskCreationOptions.AttachedToParent);

            //outerTask.Wait();
            //1st way of create & run
            var task = new Task(()
                => Console.WriteLine("hello"));
            
            task.RunSynchronously();

            
            //2nd way
            var task2 = Task.Factory.StartNew(() =>
                Console.WriteLine("Hello world"));
            


            var t3 = Task.Run(() => Console.WriteLine("Hello world last time"));


            Console.ReadLine();

            t3.Wait();//here t3 will be fully executed
        }
    }
}
