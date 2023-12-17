namespace DrivesDirectoriesFiles;

public class DirectoriesSample
{
    public static void Do()
    {
        var path = "C:\\";
        if (Directory.Exists(path))
        {
            Console.WriteLine("Subdirectories:");
            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);
            }

            //var rootDir = new DirectoryInfo(path);
            //DirectoryInfo[] directories = rootDir.GetDirectories(path);

            //foreach (var dirInfo in directories)
            //{
            //    Console.WriteLine();
            //}

            //var files = rootDir.GetFiles("*.txt");

            //var booksDirectories = rootDir.GetDirectories("books*.");


            var testPath = @"C:\Users\A441189\Desktop\test";
            var subDirPath = "subDirTest";
            var directoryInfo = new DirectoryInfo(testPath);
            if (directoryInfo.Exists)
            {
                directoryInfo.CreateSubdirectory(subDirPath);
            }

            var subDir = new DirectoryInfo($"{testPath}\\{subDirPath}");
            if (subDir.Exists)
            {
                //subDir.MoveTo(newPath);
                //subDir.Delete(true);
            }

        }
    }
}