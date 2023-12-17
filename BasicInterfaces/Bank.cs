namespace BasicInterfaces;

public class Bank
{
    public List<Account> Accounts { get; set; }

    //some other logic
}

public class Account
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}