namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimensions[0],cols = dimensions[1];

            int[,] matrix = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = data[j];
                }
            }

            int maxSum = int.MinValue;
            int bigNum = int.MinValue;
            int topLeftCol = 0;
            int TopRow = 0;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    int sum = 0;
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        topLeftCol = j;
                        TopRow = i;
                    }

                }
            }

            for (int i = TopRow; i <= TopRow+1; i++)
            {
                for (int j = topLeftCol; j <= topLeftCol + 1; j++)
                {
                    int num = matrix[i, j];
                    Console.Write(matrix[i,j] + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
