namespace CommonMistakesWithMultiThreading;

public class FileIOIssues
{
    private const string PATH = @"C:\Users\A441189\Desktop\123\New Text Document.txt";
    private readonly object _locker = new object();
    public async Task<string> ReadFile(string path)
    {
        Task.Delay(2000);

        using (var sr = new StreamReader(File.OpenRead(path)))
        {
            var data = await sr.ReadToEndAsync();
            return data;
        }
    }

    public async Task AppendLineToFile(string path, string newLine)
    {
        
        Task.Delay(2000);
        lock (_locker)
        {
            using (var sw = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                sw.WriteLine(newLine);
            }
        }
       
    }

    public async Task LaunchSample()
    {
        var t1 = Task.Run(() => AppendLineToFile(PATH, "t1"));
        var t2 = Task.Run(() => AppendLineToFile(PATH, "t2"));
        var t3 = Task.Run(() => AppendLineToFile(PATH, "t3"));

        await Task.WhenAll(t1,t2,t3);

        //Console.WriteLine(t1.Result);
        //Console.WriteLine(t2.Result);
        //Console.WriteLine(t3.Result);
    }
}