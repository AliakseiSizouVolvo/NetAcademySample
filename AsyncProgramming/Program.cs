namespace AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var fr = new FileReader();
            var data = await fr.GetDataFromFile();

            var bankAccount= new BankAccount();
           var operation1 =bankAccount.Put(1000);
           var operation2 =bankAccount.Put(1000);
           var operation3 =bankAccount.Put(1000);
           var operation4 =bankAccount.Put(1000);
           var operation5 =bankAccount.Put(1000);
           Console.WriteLine(bankAccount.Balance);

           await Task.WhenAll(operation1, operation2, operation3, operation4, operation5);
           await Task.WhenAny(operation1, operation2, operation3, operation4, operation5);

           //Console.WriteLine(await operation1);
           //Console.WriteLine(await operation2);
           //Console.WriteLine(await operation3);
           //Console.WriteLine(await operation4);
           //Console.WriteLine(await operation5);

           // Console.WriteLine(bankAccount.Balance);

           //var bobTask = PrintNameAsync("Bob");
           //var aliceTask =  PrintNameAsync("Alice");
           //var tomTask = PrintNameAsync("Tom");

           //await bobTask;
           //await aliceTask;
           //await tomTask;

        }


        //async + await
        static async Task PrintNameAsync(string name)
        {
            await Task.Delay(3000);
            Console.WriteLine(name);
        }

        static void PrintName(string name)
        {
            Thread.Sleep(3000);
            Console.WriteLine(name);
        }

        //static async void SyntaxSample()
        //{
        //    //4 types for return from async method
        //    // - void 
        //    // - Task 
        //    // - Task<T> 
        //    // ValueTask<T> 
        //    //var task = Task.Run(() => PrintNameAsync());
        //    //task.Wait();
        //    Console.WriteLine("Srart of main");
        //    await PrintNameAsync();
        //    Console.WriteLine("End of main");
        //}
    }
}
