using System.Threading.Channels;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int[], Func<int, int>> modify = (arr, change) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = change(arr[i]);
                }
            };
            Dictionary<string, Action<int[]>> operations = new Dictionary<string, Action<int[]>>()
            {
                ["add"] = arr => modify(arr,x => x + 1),
                ["multiply"] = arr => modify(arr,x => x * 2),
                ["subtract"] = arr => modify(arr,x => x - 1),
                ["print"] = arr => Console.WriteLine(string.Join(" ", arr))
            };

            int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (!operations.ContainsKey(command))
                {
                    continue;
                }

                Action<int[]> operation = operations[command];

                operation(numbers);
            }

        }
    }
}
