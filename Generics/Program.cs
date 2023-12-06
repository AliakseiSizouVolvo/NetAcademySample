namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var messageSender = new MessageSender();

            //var emailMessage = new EmailMessage("Some Email message");

            //messageSender.SendMessage(emailMessage);




            var client = new GenericClient<long>(2000101012345, "Pawel");
            var foreignerClient = new GenericClient<string>("Foreigner123", "Bob");
            var biometricClient = new GenericClient<BiometricalData>(new BiometricalData(), "Some other client");

            Console.WriteLine(GenericClient<long>.Bonus);
            Console.WriteLine(GenericClient<long>.Discount);

            Console.WriteLine(GenericClient<string>.Bonus);
            Console.WriteLine(GenericClient<string>.Discount);

            GenericClient<string>.Bonus = "No bonus";
            GenericClient<string>.Discount = 0;
            Console.WriteLine(GenericClient<long>.Bonus);
            Console.WriteLine(GenericClient<long>.Discount);

            Console.WriteLine(GenericClient<string>.Bonus);
            Console.WriteLine(GenericClient<string>.Discount);


            var baf = new BankAccountFinder();

            baf.FindAccount<GenericClient<long>, long>(
                new GenericClient<long>[] { client });

            //client = new GenericClient<string>();
        }
    }
}
