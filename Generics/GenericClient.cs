namespace Generics;

public class GenericClient<T>
{
    public T Id { get; set; }
    public static int Discount { get; set; }
    public static T Bonus { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public GenericClient(T id, string name)
    {
        Id = id;
        FullName = name;
        Bonus = default(T);
        Discount = 15;
    }
}