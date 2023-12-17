namespace DrivesDirectoriesFiles;

public class DrivesSample
{
    public static void Do()
    {
        var drives = DriveInfo.GetDrives();
        foreach (var drive in drives)
        {
            Console.WriteLine(drive.Name);
            Console.WriteLine(drive.DriveType);
            if (drive.IsReady)
            {
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.VolumeLabel);

            }
            
        }
    }
}