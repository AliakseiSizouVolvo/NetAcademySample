namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee[]
            {
                new Employee("Jhon", "Smith", 25, "developer"),
                new Employee("Vivek", "Sulu", 50, "ceo"),
                new Employee("Jane", "Doe", 28, "sneior developer"),
                new Employee("Angelo", "Markoni", 22, "developer"),
                new Employee("Bhatia", "Sahiti", 23, "developer"),
                new Employee("Sam", "Wilson", 32, "hr"),
                new Employee("Janet", "Hawk", 40, "hr"),
                new Employee("Barbara", "Blaze", 45, "ceo")
            };

            var employeesUnder30 = 
                    employees
                        .Where(x =>
                        {
                            Console.WriteLine($"Checking {x}");
                            return x.age < 30;
                        });

            Console.WriteLine("Employees under 30:");
            foreach(var empl in employeesUnder30)
            {
                Console.WriteLine($"{empl.name} {empl.surname}");
            }

            Console.WriteLine();

            Console.WriteLine("Manual enumeration of first two.");

            var enumerator = employeesUnder30.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);

            Console.WriteLine();

            Console.WriteLine("The same in reverese oreder:");
            foreach (var empl in employeesUnder30.Reverse())
            {
                Console.WriteLine($"{empl.name} {empl.surname}");
            }

            var namesPerRole = employees
                                .GroupBy(x => x.role)
                                .OrderBy(x => x.Key)
                                .Select(x => (x.Key, 
                                              "[" + string.Join(", ", x.Select(e => e.surname)) + "]"))
                                .ToArray();
               
            foreach (var r in namesPerRole)
            {
                Console.WriteLine(r);
            }

        }
    }

    public record Employee(
        string name,
        string surname,
        int age,
        string role);
}
