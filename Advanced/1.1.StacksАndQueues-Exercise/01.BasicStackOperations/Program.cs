namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(command[0]), s = int.Parse(command[1]), x = int.Parse(command[2]);

            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            if (s <= n)
            {
                for (int i = 0; i < s; i++)
                    numbers.Pop();
            }

            if (numbers.Count > 0)
            {
                if (numbers.Contains(x))
                    Console.WriteLine("true");
                else
                    Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

            
        }
    }
}
