namespace Generics;

public class Bank<T> where T : class
{
    public List<Client> Clients { get; set; }

    public Bank()
    {
        Clients = new List<Client>();
    }

    public Client GetClientById(int id)
    {
        foreach (var client in Clients)
        {
            if (client.Id.Equals(id))
            {
                return client;
            }
        }

        return null;
    }
}