using System.Net.Http.Headers;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            MethodWithParams(1,2,3,4,5,6,7,8,8,15);
            var fruits = new[] { "Apple", "Cherry", "Orange" };
            PrintAllItemsFromArray(fruits);
            MethodWithOptionalParameters(15, "Cześć");
            MethodWithOptionalParameters(25);

            DoALotOfThings("Hello", y:15);

            int x = 2;
            int y = 5;
            long area;
            var perimiter =
                CalculatePerimeterAndAreaOfRectangle(x, y, out area);

            GetNumberFromUser();
            int a = 0;
            Console.WriteLine(a);
            Do2(ref a);
            Console.WriteLine(a);


            //Do((int)1l);
            //CalculateSum(1, 2);

            //var lang = EnterLanguage();

            //var helloMes = "Hello there";

            //PrintSomeMessage(helloMes);


            //switch (lang)
            //{
            //    case "EN":
            //        PrintSomeMessage(SayHelloEn());
            //        break;
            //    case "FR":
            //        PrintSomeMessage(SayHelloFr());
            //        break;
            //    case "PL":
            //        PrintSomeMessage(SayHelloPl());
            //        break;
            //    default:
            //        Console.WriteLine("Incorrect input");
            //        break;
            //}

        }

        static void PrintAllItemsFromArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void MethodWithParams(params int[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void DoALotOfThings(string helloMessage="Hello, World", int x=0, int y=0, string anotherMessage = "123123123")
        {
            Console.WriteLine(helloMessage);
            Console.WriteLine(x+y);
            Console.WriteLine(anotherMessage);
        }

        static void MethodWithOptionalParameters(int x, string message = "Hello", int y=1)
        {
            Console.WriteLine(x);
            Console.WriteLine(message);
        }

        static string SayHelloEn()
        {
            return "Hello, World!";
        }

        static string SayHelloPl()
        {
            return "Cześć!";
        }

        static string SayHelloFr()
        {
            return "Salut!";
        }

        static void PrintSomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string EnterLanguage()
        {
            Console.WriteLine("Type lang: EN or FR or PL");
            var lang = Console.ReadLine();
            return lang;
        }

        static long CalculateSum(int x, int y)
        {
            return (long)x + y;
        }

        static void Do(int x)
        {
            Console.WriteLine(x);
        }

        static void Do2(ref int x)
        {
            x++;
            Console.WriteLine(x);
        }

        static void Do2ButXShouldntBeChanged(in int x)
        {
            //x++;
            Console.WriteLine(x);
        }

        static int GetNumberFromUser()
        {
            var x = Console.ReadLine();
            var isNumber = int.TryParse(x, out int number);
            //int outNumber = 0;
            //var isNUmber = int.TryParse(x, out outNumber);
            return number;
        }

        static long CalculatePerimeterAndAreaOfRectangle(int length, int height, out long area)
        {
            var perimeter = ((long)length + height) * 2;
            area = (long)length * height;
            return perimeter;
        }
    }
}
