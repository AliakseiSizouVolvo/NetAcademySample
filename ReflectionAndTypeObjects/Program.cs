using System.Reflection;

namespace ReflectionAndTypeObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Access private static methods on a known type

            var type1 = typeof(Foo);

            var method1 = type1.GetMethod("DoSomethingPrivate", BindingFlags.Static
                                                                | BindingFlags.NonPublic);


            method1.Invoke(null, new object[] { "Hello world!" });

            /////////////////////////////////////////////////////////////////////////////

            // Access instance methods on an unknown type

            object subject = new Foo(); // notice, var has type 'object' - we can't access antying without cast

            var type2 = subject.GetType(); // same Type object as above
            Console.WriteLine(type2.FullName);

            var method2 = type2.GetMethod("SetBar", BindingFlags.Instance
                                                    | BindingFlags.Public);

            Console.WriteLine(method2.Name);

            method2.Invoke(subject, new object[] { 5 });

            Console.WriteLine($"Current Bar state is {subject}");

            // notice, reflection let's you attempt to do ANYTHING, but will faile at runtime if you do the wrong thing

            method2.Invoke(subject, new object[] { "5" });
        }

        public class Foo
        {
            private static void DoSomethingPrivate(string value)
            {
                Console.WriteLine($"Inside private static methods, arg is \"{value}\"");
            }

            public int Bar { get; private set; } = 1;

            public void SetBar(int val) => Bar = val;

            public override string ToString()
            {
                return $"Foo {{ Bar: {Bar} }}";
            }
        }
    }
}
