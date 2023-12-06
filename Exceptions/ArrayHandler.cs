namespace Exceptions;

public class ArrayHandler
{
    public int[] Array { get; set; }


    public void Do()
    {
        try
        {
            var length = Array.Length;
            
            var lastElement = Array[length];
        }
        catch (Exception e)
        {
            //throw;
            throw new MyAmazingCustomException("123", 
                e.Message, 
                e)
            {
                
            };
        }
        finally
        {
            Console.WriteLine("hello there");
        }
    }
}