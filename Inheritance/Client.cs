namespace Inheritance;

public class Client : Person
{
    public BankAccount[] BankAccounts { get; private set; }

    public Client(string name, string address, string contact, BankAccount[] accounts)
        : base(name, address, contact)
    {
        BankAccounts = accounts;
    }

    public void OperateWithAccount()
    {
        Console.WriteLine("Some account operation");
    }

}