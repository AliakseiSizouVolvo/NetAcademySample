namespace Collections;

public class DictionarySample
{
    public Dictionary<string, User> usersDict = new Dictionary<string, User>()
    {
        {"test@email.com", new User()
        {
            Email = "test@email.com",
            Password = "123"
        }},
        {"test2@email.com", new User()
        {
            Email = "test2@email.com",
            Password = "123"
        }}
    };

    public void Sample()
    {
        //take element by key
        var value = usersDict["test@email.com"];
        //var value2 = usersDict.TryGetValue()
        //if no key in dict => exception

        var count = usersDict.Count;
        
        foreach (var user in usersDict)
        {
            Console.WriteLine(user.Key);
            Console.WriteLine(user.Value);
        }

        usersDict.Add("123", new User());//if key is exist -> exception
        //usersDict.TryAdd()//no exception

        //contains check
        usersDict.ContainsKey("1");
        usersDict.ContainsValue(new User());

    }
}