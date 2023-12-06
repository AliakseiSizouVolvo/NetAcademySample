namespace Exceptions;

public class ExceptionHandler
{
    public void Handle()
    {
        try
        {

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine(a / b);

            var array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Enter index of array from 0 to 9");
            var isIndexParsed = int.TryParse(
                Console.ReadLine(), out int index);
            var element = array[index];

            object object1 = "ABC";

            var x = Convert.ToInt32(object1);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{ex.Message}. Try to avoid divide by zero.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"{ex.Message}. Enter value from 0 to 9.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}