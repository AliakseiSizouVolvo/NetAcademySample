namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //explicit & widening
                var intValue = 15;
                var longValue = (long)(intValue + 15000);

                //explicit & narrowing
                var newIntValue = (int)(longValue);

                //explicit 
                var x = 1000000;
                var z = (long)x;

                //implicit
                long a = x;

                var bigLongValue = 45000000000;
                var intValueForLostData = (int)(bigLongValue);
                Console.WriteLine(intValueForLostData);

                var longValueForTest = int.MaxValue + 1l;
                Console.WriteLine((int)longValueForTest);

                var convertedIntValueWithCheck = (checked((int)bigLongValue));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}