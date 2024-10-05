using System.Security.Cryptography.X509Certificates;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> isValid = x => x % n != 0;

            List<int> validNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (isValid(number))
                {
                    validNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", validNumbers));
        }
    }
}
