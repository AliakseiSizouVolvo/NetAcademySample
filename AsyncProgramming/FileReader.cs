namespace AsyncProgramming;

public class FileReader
{
    public async Task<string> GetDataFromFile()
    {
        const string PATH = @"C:\Users\A441189\Desktop\NetAcademy\text.txt";
        var list = new List<string>();
        using (var sr = new StreamReader(File.OpenRead(PATH)))
        {
            while (!sr.EndOfStream)
            {
                var line = await sr.ReadLineAsync();
                list.Add(line);
            }
            return list.Aggregate((current, s1) => current += s1);
        }
    }
}