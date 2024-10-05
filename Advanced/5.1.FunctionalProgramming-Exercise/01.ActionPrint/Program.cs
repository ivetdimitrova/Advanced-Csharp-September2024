namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> print = name => Console.WriteLine(name);

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
