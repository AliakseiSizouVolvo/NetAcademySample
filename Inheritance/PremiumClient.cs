namespace Inheritance;

public sealed class PremiumClient : Client
{
    public int Discount { get; set; }
    public PremiumClient(string name,
        string address,
        string contact,
        BankAccount[] accounts) : base(name, address, contact, accounts)
    {

    }
}

//public class SomeClient : PremiumClient
//{

//}