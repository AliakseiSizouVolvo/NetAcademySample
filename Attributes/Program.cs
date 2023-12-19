using System.Text.Json;

namespace Attributes;

internal class Program
{
    static void Main(string[] args)
    {
        var user = new User()
        {
            Id = "A123456",
            Name = "Jhon",
            Surname = "Smith",
            Age = 25,
            Role = "Senior Developer"
        };

        Console.WriteLine(user);
        Console.WriteLine();

        SensitiveDataAttribute.PurgeSensitiveData(user);
        Console.WriteLine(user);
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class SensitiveDataAttribute: Attribute
{
    public static void PurgeSensitiveData(object obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        foreach (var property in properties) 
        {
            var hasSensitiveDataAttribute =
                    property.CustomAttributes
                            .Any(x => x.AttributeType == typeof(SensitiveDataAttribute));

            if (!hasSensitiveDataAttribute)
            {
                continue;
            }

            var defaultValue = property.PropertyType.IsClass
                                    ? null
                                    : Activator.CreateInstance(property.PropertyType);

            property.SetValue(obj, defaultValue);
        }
    }
}

public class User
{
    public required string Id { get; set; }

    [SensitiveData]
    public required string Name { get; set; }

    [SensitiveData]
    public required string Surname { get; set; }

    [SensitiveData]
    public int Age { get; set; }

    public required string Role { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
    }
}
