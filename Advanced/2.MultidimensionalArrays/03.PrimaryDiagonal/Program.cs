using System.Diagnostics.CodeAnalysis;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimension,dimension];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = data[j];
                }
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sum += matrix[i,j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
