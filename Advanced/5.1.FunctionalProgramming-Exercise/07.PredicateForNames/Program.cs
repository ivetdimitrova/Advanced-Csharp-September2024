namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> isValid = name => name.Length <= length;

            Action<string[], Predicate<string>> printValidName = (names, predicate) =>
            {
                foreach (string name in names)
                {
                    if (predicate(name))
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            printValidName(names, isValid);
        }
    }
}
