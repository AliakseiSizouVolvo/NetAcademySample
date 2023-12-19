using System.Reflection;
using System.Text;

namespace ReflectionAndTypeObjects;

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

        object subject1 = Activator.CreateInstance(type1);

        var type2 = subject1.GetType(); // same Type object as above
        Console.WriteLine(type2.FullName);

        var method2 = type2.GetMethod("SetBar", BindingFlags.Instance
                                                | BindingFlags.Public);

        Console.WriteLine(method2.Name);

        method2.Invoke(subject1, new object[] { 5 });

        Console.WriteLine($"Current Bar state is {subject1}");

        // notice, reflection let's you attempt to do ANYTHING, but will faile at runtime if you do the wrong thing

        try
        {
            method2.Invoke(subject1, new object[] { "5" });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //////////////////////////////////////////////////////////

        dynamic subject2 = subject1;

        // this looks like normal code, but compiler knows nothing about it,
        // it will only be resolved at runtime.
        subject2.SetBar(10);

        Console.WriteLine($"Current Bar state is {subject2}");

        // notice, once again, you can try ANYTHING, but it will fail at runtime
        try
        {
            subject2.SetBar("15");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        ///////////////////////////////////////////////////////////

        // make sure the project ReflectionAndTypeObjects.AssemblyForLoad was built in debug mode
        Assembly sampleAssembly = Assembly.LoadFrom("..\\..\\..\\..\\ReflectionAndTypeObjects.AssemblyForLoad\\bin\\Debug\\net8.0\\ReflectionAndTypeObjects.AssemblyForLoad.dll");

        var assemblyLoadSubjectType =  sampleAssembly.GetTypes()
                                            .Where(x => x.Name == "AssemblyLoadSubject")
                                            .Single();

        assemblyLoadSubjectType
            .GetMethod("SomeMethod", BindingFlags.Static | BindingFlags.Public)
            .Invoke(null, new object[0]);
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

