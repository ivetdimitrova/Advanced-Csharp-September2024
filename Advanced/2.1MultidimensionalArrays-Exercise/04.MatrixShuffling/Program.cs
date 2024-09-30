namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0],cols = dimensions[1];

            string[,] matrix = new string[rows,cols];

            for(int i = 0; i < rows;i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = data[j];
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (IsValid(command, matrix))
                {
                    string operation = command[0];
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    
                    string num = matrix[row1, col1];
                    string num2 = matrix[row2, col2];
                    matrix[row1, col1] = num2;
                    matrix[row2, col2] = num;

                    for (int i = 0; i < rows; i++)
                    { 
                        for (int j = 0; j < cols; j++)
                        {
                                Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static bool IsValid(string[] command, string[,] matrix)
        {
            bool isValid = false;
            if (command.Length == 5)
            {
                string operation = command[0];
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                isValid = operation == "swap"
                       && row1 <= matrix.GetLength(0)
                       && row2 <= matrix.GetLength(0)
                       && col1 <= matrix.GetLength(1)
                       && col2 <= matrix.GetLength(1);
            }

            return isValid;
        }

    }
}
