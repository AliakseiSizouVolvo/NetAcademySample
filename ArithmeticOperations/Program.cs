namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 27;
            var y = 13;

            var sum = x + y;
            var result = x - y;
            var multiplication = x * y;
            var dividing = x / y;//y shouldn't be 0
            double dividingDouble = (double)x / y;//y shouldn't be 0
            float dividingFloat = (float)x / y;//y shouldn't be 0
            decimal dividingDecimal = (decimal)x / y;//y shouldn't be 0
            var smth = x % y;


            Console.WriteLine(sum); //40
            Console.WriteLine(result); //14
            Console.WriteLine(multiplication); //bignumber
            Console.WriteLine(dividingDouble); // 2.smth
            Console.WriteLine(dividingFloat); // 2.smth
            Console.WriteLine(dividingDecimal); // 2.smth
            Console.WriteLine(smth);


            Console.WriteLine(x);//27

            x++; // x = x+ 1;
            Console.WriteLine(x);

            ++x; // x = x+1;
            Console.WriteLine(x);

            x--; // x = x-1;
            Console.WriteLine(x);

            --x; //x = x-1;
            Console.WriteLine(x);
            //x = 27;

            Console.WriteLine(x++);//27
            //Console.Wl(x);
            //x=x+1;
            //x = 28;



            Console.WriteLine(++x);//29
            //x = x +1;
            //console.Wl(x)


           var str1 = "Str1";
           var str2 = "Str2";

            Console.WriteLine(str1+str2);

            //str1++;

            var a = 2; //010
            var b = 5; //101
            var c = 4; //100


            Console.WriteLine(a & b); // 0*1 1*0 0*1 => 0 0 0
            // | if at least 1 of '1' => 1 
            Console.WriteLine(a | b); // (0 or 1) (1 or 0) (0 or 1) => 1 1 1 => 7
            Console.WriteLine(b | c); // (1 or 1) (0 or 0) (1 or 0) => 1 0 1 -> 5
            //logical exclusive OR (XOR) - if values are same => 1, otherwise -> 0
            Console.WriteLine(a ^ b); // (1, 0) (0,1) (1,0) => 1 1 1 => 7
            Console.WriteLine(b ^ c); // (1, 1) (0,1) (1,0) => 0 0 1 => 1

            var valueForEncrypt = 45;
            var key = 111;

            var encrypted = valueForEncrypt ^ key;
            Console.WriteLine(encrypted);

            var decrypted = encrypted ^ key;
            Console.WriteLine(decrypted);

            //logical negation or inversion
            Console.WriteLine(~a);

            var v = 15;
            Console.WriteLine(v<<1);
            Console.WriteLine(v>>1);

            x += 5; // x = x+5;


        }
    }
}