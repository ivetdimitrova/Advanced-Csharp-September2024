namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> checker = w => w[0] == w.ToUpper()[0];

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => checker(w))
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
