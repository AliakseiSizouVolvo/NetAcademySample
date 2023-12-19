using System.Reflection;

namespace AssemblyResources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("Sample.txt"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }
    }
}
