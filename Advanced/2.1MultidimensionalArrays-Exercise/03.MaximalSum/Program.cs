using System.Runtime.Serialization.Formatters;

namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0], cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[j];
                }
            }
            if (rows >= 3 && cols >= 3)
            {
                int maxSum = int.MinValue;
                int row = 0;
                int col = 0;


                for (int i = 0; i < rows - 2; i++)
                {
                    for (int j = 0; j < cols - 2; j++)
                    {
                        int sum = Sum(matrix, i, j);

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            row = i;
                            col = j;
                        }
                    }
                }


                Console.WriteLine($"Sum = {maxSum}");
                Print(matrix, row, col);
            }


        }

        private static void Print(int[,] matrix, int startRow, int startCol)
        {
            for (int i = startRow; i <= startRow + 2; i++)
            {
                for (int j = startCol; j <= startCol + 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }


        }

        private static int Sum(int[,] matrix, int row, int col)
        {
            int sum = 0;

            for (int i = row; i <= row + 2; i++)
            {
                for (int j = col; j <= col + 2; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}
