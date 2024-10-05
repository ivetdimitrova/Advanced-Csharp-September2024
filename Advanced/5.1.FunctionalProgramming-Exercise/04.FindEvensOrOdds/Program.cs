using System.Threading.Channels;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            Predicate<int> IsEven = n => n % 2 == 0;
            Predicate<int> IsOdd = n => n % 2 != 0;

            List<int> numbers = new List<int>(); 
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (command == "even" && IsEven(i))
                {
                    numbers.Add(i);
                }
                else if (command == "odd"&&IsOdd(i))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
