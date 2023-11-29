namespace VariablesAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string LAST_NAME = "Smith";//123123

            //LAST_NAME = "111";

            /*23
             1
             3123
             21
             13123
             
             */


            //bool
            bool isAlive = true;

            //byte (1 byte)
            byte testByteVariable = 150;

            //sbyte (1 byte) 
            sbyte testSByteVariable = -128;


            //short (2 bytes => -2^15 ... 2^15-1 ) 
            //System.Int16
            short testShortValue = 25000; //-32768 32767

            //ushort
            ushort testUSHortValue = 15; //0 - 65535

            //int (4 bytes) 
            //int min value  = -2 147 483 648
            int testIntValue = 66;

            //max value ~4.29B
            ushort testUIntValue = 5;

            //long 9 223 372 036 854 775 807
            long testLongValue = 9223372036854775807;

            //ulong for only positive
            ulong testUlong; //up to 2^64-1

            //float - 4 byte
            // -3.4*10^38 - 3.4*10^38
            // if we work with small float number
            float testFloatValue = 15.5f;

            //double - 8 bytes
            // +/- 5 * 10^(-324) - +/- 1.7*10^308
            // by default
            double testDoubleValue = 15.5;

            // decimal - 16 bytes
            //+/-1 * 10^(-28) ... 7.9228 * 10^(28)
            //when we need a big amount numbers after .
            decimal testDecimalValue = 15.5m;


            //char
            //one symbol from Unicode(2 bytes) 
            char testCharValue = 'A';
            char testCharValue2 = '\x5A';
            char testCharValue3 = '\u0420';


            //string
            string testString = "Hello World";


            //object 
            //System.Object
            object testObject = new { };


            var x = 15;

            var zx = 5l;//long

            var d = 3.5;

            //var L;

            //var obj = null;

            Console.WriteLine("123123");
        }
    }
}