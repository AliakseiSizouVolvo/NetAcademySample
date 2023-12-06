namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var b = new ClassB();
                //b.Do();
                Console.WriteLine(b.DoSmth());
                Console.WriteLine(b?.A?.HelloMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //try
            //{
            //    var arrayHandler = new ArrayHandler()
            //    {
            //        Array = new[] { 1, 2, 3, 4, 5, 7 }
            //    };
            //    arrayHandler.Do();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            var exHandler = new ExceptionHandler();
            exHandler.Handle();
            
            //try
            //{


            //    Console.WriteLine("Hello after exception");
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine(e.Message);
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //finally
            //{
            //    Console.WriteLine("App finish work");
            //}
        }
    }
}
