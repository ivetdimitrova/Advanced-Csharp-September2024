namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minValue = int.MaxValue;
            Func<int, int, int> minFunc = (x, y) =>
            {
                if (x < y) return x;
                else return y;
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                minValue = minFunc(minValue, numbers[i]);
            }

            Console.WriteLine(minValue);
        }
    }
}
