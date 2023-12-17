namespace Strings;

public class StringFormatting
{
    public void FormatStringSample()
    {
        var str = "Bob";
        var age = 20;

        Console.WriteLine("Name: {0}, Age: {1}", str, age);
        Console.WriteLine("Name: {2}, Age: {0}, {1}", str, age, "1");
        //Name: 1, Age: Bob, 20

        Console.WriteLine(string.Format("Name: {0}, Age: {1}", str, age));

        var num = 23.75415;
        Console.WriteLine(string.Format("{0:c2}", num));

        var number = 12312312213421234221;
        Console.WriteLine(number.ToString("+# (###) ###-###-###-###-###"));

        //interpolation
        str = $"123123 {number:E}";

        var path = @"C:\Users\A441189\Desktop\NetAcademy\Strings\StringFormatting.cs ";
    }
}