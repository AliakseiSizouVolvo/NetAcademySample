using Microsoft.VisualBasic.CompilerServices;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Tom Brown",
                
                "st.QWERTY city YTREWQ",
                "+123456789",
                new BankAccount[]
                {
                    new BankAccount()
                    {
                        BankAmount = 123
                    }
                });

            var employee = new Employee(
                "Jack White",
                "ZXCV st, c.QWERTY",
                "qwe@ema.il",
                "Regular"
            );

            employee.JustLiveLife();
            client.JustLiveLife();



            var cat = new Cat()
            {
                Age = 2,
                Color = "White and Black"
            };

            var lion = new Lion()
            {
                Age = 5,
                Color = "Brown",
                Location = "Africa"
            };

            Cat cat1 = new Lion();
            Cat cat2 = lion;


            Lion lion1 = (Lion)cat2;
            //is and as
            var lion3 = cat as Lion;

            if (cat is Lion)
            {
                Lion lion2 = (Lion)cat;
            }

        }

        static Cat GenerateCat()
        {
            var cat = new Lion();
            return cat;
        }
    }
}
