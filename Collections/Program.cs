using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var qns = new QueueAndStackSample();

            qns.Sample();

            var names = new List<string>()
            {
                "Tom",
                "Bob",
                "Alice",
                "John"
            };

            names.Add("Mike");

            var newList = new List<string>(names);
            var listWith5Elements = new List<string>(5);

            //.Net 8+ (C# v.12)
            //List<int> intList = [];
            //intList = [1,2,3];

            var peopleList = new List<string>()
            {
                "Tom",
                "Tim",
                "Mary"
            };

            var firstEl = peopleList[0];
            Console.WriteLine(firstEl);
            peopleList[0] = "Mike";
            Console.WriteLine(firstEl);

            Console.WriteLine($"List length = {peopleList.Count}");
            //Console.WriteLine($"List length = {peopleList.Count()}");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");

            peopleList.Add("Bill");
            Console.WriteLine($"List length = {peopleList.Count}");
            //Console.WriteLine($"List length = {peopleList.Count()}");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");

            peopleList.Add("Mark");
            Console.WriteLine($"List length = {peopleList.Count}");
            //Console.WriteLine($"List length = {peopleList.Count()}");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");

            peopleList.Add("Steven");
            Console.WriteLine($"List length = {peopleList.Count}");
            //Console.WriteLine($"List length = {peopleList.Count()}");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");


            peopleList.Add("1");
            peopleList.Add("1");
            peopleList.Add("1");
            Console.WriteLine($"List length = {peopleList.Count}");
            //Console.WriteLine($"List length = {peopleList.Count()}");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");


            Console.ReadLine();
            peopleList.Capacity = 1;
            Console.WriteLine($"List capacity = {peopleList.Capacity}");
            peopleList.Add("1");
            Console.WriteLine($"List capacity = {peopleList.Capacity}");


            foreach (var person in peopleList)
            {
                Console.WriteLine(person);
            }
            

            //var hashTable = new Hashtable();
            //hashTable.Add(1, "One");
            //hashTable.Add(2, 2);
            //hashTable.Add(3, '3');


            //var value = hashTable[2];

            //var str = "12321123asdasd qsad ad 1";
            //var strHash = str.GetHashCode();

            //int x = 0;
            //int? y = 0;

            //y = null;
            //var arrayList = new ArrayList();
            //arrayList.Add(2);
            //arrayList.Add(null);
            //arrayList.Add("string");
            //arrayList.Add('x');


        }
    }
}
