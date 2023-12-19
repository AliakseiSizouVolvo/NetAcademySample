using System.Reflection;
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
            Email = "Jhon.Smith@acme.org",
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
    public object DefaultValue { get; set; }
    //public SensitiveDataAttribute(object defaultValue = null)
    //{
    //    DefaultValue = defaultValue;
    //}

    public static void PurgeSensitiveData(object obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        foreach (var property in properties) 
        {
            var hasSensitiveDataAttribute =
                    property.GetCustomAttributes<SensitiveDataAttribute>()
                            .SingleOrDefault();

            if (hasSensitiveDataAttribute == null)
            {
                continue;
            }

            object? defaultValue = hasSensitiveDataAttribute.DefaultValue 
                                    ?? (property.PropertyType.IsClass
                                        ? null
                                        : Activator.CreateInstance(property.PropertyType));

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

    [SensitiveData(DefaultValue = "hr@acme.org")]
    public required string Email { get; set; }

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
