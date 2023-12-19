namespace GarbageCollectorAndFinalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make sure you are running in Release mode without debug breakpoints - " +
                "they may interfiere with Garbage Collector.");

            PrintCurrentUsedMemory();

            var container = new Container();

            var random = new Random(7);
            for (int i = 0; i < 10 * 1024; i++) 
            {
                var buffer = new byte[1024];
                random.NextBytes(buffer);
                container.Content.Add(buffer);
            }

            PrintCurrentUsedMemory();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            PrintCurrentUsedMemory();

            Container.StaticReference = container;

            container = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            PrintCurrentUsedMemory();

            Console.WriteLine($"container is currently in generation {GC.GetGeneration(Container.StaticReference)}");

            Container.StaticReference = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            PrintCurrentUsedMemory(); // now object is gone
        }

        private static void PrintCurrentUsedMemory()
        {
            var usedDemoryAmount = GC.GetTotalMemory(true);
            var usedMemoryDesription = BytesToString(usedDemoryAmount);
            Console.WriteLine(usedMemoryDesription);
        }

        //https://stackoverflow.com/a/4975942
        public static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }

    public class Container
    {
        public static Container? StaticReference { get; set; }

        public List<byte[]>? Content { get; set; } = new List<byte[]>();

        ~Container()
        {
            System.Console.WriteLine("Finalizer firing.");
        }
    }


}
