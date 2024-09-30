
namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0], cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            int count = 0;
            for (int i = 0; i < rows -1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (IsSquareMatrix(matrix, i, j))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static bool IsSquareMatrix(char[,] matrix, int i, int j)
        {
            char symbol = matrix[i, j];
            bool isSquareMatrix = matrix[i, j] == symbol
                                  && matrix[i, j + 1] == symbol
                                  && matrix[i + 1, j ] == symbol
                                  && matrix[i + 1, j + 1] == symbol;

            return isSquareMatrix;
        }
    }
}
