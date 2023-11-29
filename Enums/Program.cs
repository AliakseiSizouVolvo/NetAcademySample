namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time of a day(Morning, Day, Evening, Night):");
            var timeOfDay = Console.ReadLine();

            var isTimeOfDay = TimeOfDay.TryParse(timeOfDay, out TimeOfDay timeOfDayValue);



            switch (timeOfDayValue)
            {
                case TimeOfDay.Day:
                    Console.WriteLine("Have a good day");
                    break;
                case TimeOfDay.Morning:
                    Console.WriteLine("Good Morning");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good evening");
                    break;
                case TimeOfDay.Night:
                    Console.WriteLine("Have a good night");
                    break;
                default:
                    break;

            }

            var error = (WebErrors)404;

            var notFoundError = WebErrors.NotFound;
        }
    }
}
