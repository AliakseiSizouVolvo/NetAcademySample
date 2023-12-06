namespace Generics;

public class BankAccountFinder
{
    public TY FindAccount<T, TY>(T[] accounts)
        where T : GenericClient<TY>
    {
        //some logic
        return accounts[0].Id;
    }
}