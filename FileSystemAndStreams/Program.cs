using System.Text;
using System.Text.Json;

namespace FileSystemAndStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();

            foreach (var drv in drives)
            {
                Console.WriteLine($"Drive: {drv.Name}, Total Size: {drv.TotalSize}, Free Space: {drv.TotalFreeSpace}");
            }

            //////////////////////////////////////////////////////////////////////

            Console.WriteLine($"Working directory: {System.IO.Directory.GetCurrentDirectory()}");

            // Relative paths like below are relative to working directory (above)
            var directoryPath = @".\NetAcademySamples";

            var directoryInfo = new DirectoryInfo(directoryPath);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }

            Console.WriteLine($"Files will be in directory: {directoryInfo.FullName}");

            ////////////////////////////////////////////////////////////////////////////

            var fileInfo = new FileInfo(Path.Combine(directoryInfo.FullName, "Hello World.txt"));
            using (var textWriter = fileInfo.CreateText())
            {
                textWriter.Write("Hello World!");
            }

            //////////////////////////////////////////////////////////////////////////////

            using var str = File.OpenRead(directoryPath + @"\Hello World.txt");

            var res = new byte[5];

            str.Read(res);
            Console.WriteLine($"Stream position: {str.Position}");
            Console.WriteLine($"Bytes read: {SerializeByteArrayAsJsonNumArray(res)}");

            str.Read(res);
            Console.WriteLine($"Stream position: {str.Position}");
            Console.WriteLine($"Bytes read: {SerializeByteArrayAsJsonNumArray(res)}");

            str.Seek(-10, SeekOrigin.Current);
            Console.WriteLine($"Stream position: {str.Position}");

            str.Read(res);
            Console.WriteLine($"Stream position: {str.Position}");
            Console.WriteLine($"Bytes read: {SerializeByteArrayAsJsonNumArray(res)}");

            ////////////////////////////////////////////////////////////

            using var str2 = File.Open(directoryPath + @"\Hello World2.txt", FileMode.Create);
            using var writer2 = new StreamWriter(str2);
            writer2.Write('a');
            writer2.Write('ą');

            //////////////////////////////////////////////////////////////

            using var str3 = File.Open(directoryPath + @"\Hello World3.txt", FileMode.Create);
            using var writer3 = new StreamWriter(str3, Encoding.ASCII);
            writer3.Write('a');
            writer3.Write('ą'); // will be written impropperly 

            //////////////////////////////////////////////////////////////

            using var str4 = File.Open(directoryPath + @"\Hello World4.dat", FileMode.Create);
            {
                using var writer4 = new BinaryWriter(str4);
                {
                    writer4.Write((uint)Math.Pow(2, 31));
                    writer4.Write("ABC");
                    writer4.Write(new String('B', 127));
                    writer4.Write(new String('C', 130));    // 130 = 10000010, notice, string length now takes 2 bytes
                    writer4.Write(1.25f);
                    writer4.Flush();
                }
            }

            ///////////////////////////////////////////////////////////////
            // try removing "using" from str4 and writer4, see if you get access error
            using var str5 = File.OpenRead(directoryPath + @"\Hello World4.dat");
            using var reader = new BinaryReader(str5);
            Console.WriteLine($"Value read: {reader.ReadUInt32()}");
            Console.WriteLine($"Value read: {reader.ReadString()}");
            Console.WriteLine($"Value read: {reader.ReadString()}");
            Console.WriteLine($"Value read: {reader.ReadString()}");
            Console.WriteLine($"Value read: {reader.ReadSingle()}");

            str5.Seek(0, SeekOrigin.Begin);
            Console.WriteLine($"Value read: {reader.ReadInt32()}"); ; // notice we get a different value, because we are reading UInt bytes as Int
        }

        public static string SerializeByteArrayAsJsonNumArray(byte[] arr) => 
                JsonSerializer.Serialize(arr.Select(x => (int)x).ToArray());

    }
}
