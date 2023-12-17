using System.Text;

namespace DrivesDirectoriesFiles;

public class FilesSample
{
    public static void Do()
    {
        var testPath = @"C:\Users\A441189\Desktop\test";

        var directory = new DirectoryInfo(testPath);

        var files = directory.GetFiles();

        foreach (var fileInfo in files)
        {
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Length);

            //fileInfo.
        }
        //create/copy/delete 

        File.Create($"{testPath}\\Test.txt");

        var filePath = $"{testPath}\\Test2.txt";
        var fi = new FileInfo(filePath);
        if (!fi.Exists)
        {
            fi.Create();
        }

        //fi.CopyTo($"{testPath}\\CopyOfTest2.txt");

        File.Delete($"{testPath}\\CopyOfTest2.txt");

        //read & write
        var data = "Some random number string 123123123912031293-01231";

        //write
        //fi.AppendText();//stream wtirer option to create
        //File.AppendAllText(filePath, data);

        File.WriteAllText(filePath, data, Encoding.Latin1);


        var str2 = "łłłłłłłł";

        File.AppendAllTextAsync(filePath, str2, Encoding.Default);

        var str3 = "😀😀😀😀😀😀";
        File.AppendAllTextAsync(filePath, str3, Encoding.UTF8);


        //read data 

        //var dataInFile = File.ReadAllText(filePath,Encoding.Latin1);
        //Console.WriteLine(dataInFile);

        //dataInFile = File.ReadAllText(filePath, Encoding.UTF8);
        //Console.WriteLine(dataInFile);
    }
}