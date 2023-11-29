namespace ConditionalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Is cat alive?");

            //var isShredingerCatAlive = Convert
            //    .ToBoolean(Console.ReadLine());

            //if (isShredingerCatAlive)
            //{
            //    Console.WriteLine("Cat is alive");
            //}
            //else
            //{
            //    Console.WriteLine("Cat is not alive");
            //}


            Console.WriteLine("It's a simple console menu. Select correct menu option:");
            Console.WriteLine("1: First point");
            Console.WriteLine("2: Second point");
            Console.WriteLine("3: Third point");
            Console.WriteLine("4: Forth point");
            var selectedOption = Convert.ToInt32(Console.ReadLine());
            //console menu using if
            //if (selectedOption == 1)
            //{
            //    Console.WriteLine("First menu point");
            //}

            //else if (selectedOption == 2)
            //{
            //    Console.WriteLine("Second menu point");

            //}

            //else if (selectedOption == 3)
            //{
            //    Console.WriteLine("Third menu point");

            //}
            //else if (selectedOption == 4)
            //{
            //    Console.WriteLine("Forth menu point");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect option was selected");
            //}

            //console menu using switch

            switch (selectedOption)
            {

                case 1:
                    Console.WriteLine("First menu point");
                    break;
                case 2:
                    Console.WriteLine("Second menu point");
                    break;
                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }

            //using logical expression in if
            Console.WriteLine("Please enter int X:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int Y:");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int Z:");
            var z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x>z)
            {
                Console.WriteLine("X is the biggest one");
            }

            else if(y>x && y>z) { }
            {
                Console.WriteLine("Y is the biggest one");
            }




            //ternary operation
            x = 10;
            y = 15;

            var result = x > y 
                ? "x>y" //what happen if it's true
                : "y<=x"; // if false

            //ternary operation equivalent
            string result2;
            if (x > y)
            {
                result2 = "x>y";
            }
            else
            {
                result2 = "y<=x";
            }
        }
    }
}