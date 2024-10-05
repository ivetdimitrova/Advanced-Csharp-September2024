namespace _05.FilterByAge
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person person = new Person(data[0], int.Parse(data[1]));

                people.Add(person);
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);

            PrintPeople(people, filter, printer);
        }

        private static void PrintPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }

        public static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            switch (condition)
            {
                case "younger":
                    return x => x.Age < ageThreshold;
                case "older":
                    return x => x.Age >= ageThreshold;
                    default:
                    return x => false;
            }
            
        }

        public static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Name}");
                case "age":
                    return person => Console.WriteLine($"{person.Age}");
                case "name age":
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                default:
                    return null;
            }
        }
    }
}
