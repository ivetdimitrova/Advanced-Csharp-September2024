namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = array[j];
                }
            }
            int firstSum = 0;
            for (int i = 0; i < n; i++)
            {
                firstSum += matrix[i, i];
            }

            int secondSum = 0;
            for (int i = 1; i <= n; i++)
            {
                secondSum += matrix[i -1, n - i];
            }

            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }
    }
}
