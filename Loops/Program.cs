namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (;;)
            //{

            //    Console.WriteLine("Hello world");
            //    //x++;

            //    //if (x == 1000)
            //    //{
            //    //    var z = 15;
            //    //}

            //}
            //show multiplication table from (0 - 10):
            //var value = Convert.ToInt32(Console.ReadLine());
            //for (var i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(value * i);
            //}

            //var a = 15;
            //for (;; )
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}


            //for (int i = 0; ; i++)
            //{
            //    if (i== 1000)
            //    {
            //        break;
            //    }
            //}



            var x = 10000;

            //do 
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 1000);

            x = 10000;
            while (x < 1000)
            {
                Console.WriteLine(x);
                x++;
            }

            //break sample
            var amountOfGoodDeletion = 0;
            var someValue = 13987;
            while (true)
            {
                if (someValue % 179 ==0 )
                {
                    amountOfGoodDeletion++;
                }

                if (amountOfGoodDeletion == 3)
                {
                    break;
                }
                {
                    
                }
                Console.WriteLine(someValue);
                someValue++;
            }

            //continue
            for (int i = 0; i < 100; i++)
            {
                if (!((i%2==0) && (i%3==0) && (i%5==0)))                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}