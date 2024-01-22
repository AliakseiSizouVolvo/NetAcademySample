namespace PartialClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var partialClassInstance = new Logic.TestPartialClass()
            {
                Property1 = 1,
                Property2 = 2,
                Property3 = 3,
                Property4 = 4,
            };

            partialClassInstance.Do(17);

            partialClassInstance.DoSmthElse();
        }
    }
}
