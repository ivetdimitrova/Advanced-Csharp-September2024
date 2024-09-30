namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int rows = dimensions, cols = dimensions;
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                //char[] data = Console.ReadLine().Split("",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                string data = Console.ReadLine();
                if (data.Length == cols)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = data[j];
                    }
                }
               
            }

            char symbol = char.Parse(Console.ReadLine());

            int n = 0;
            bool IsSymbol = false;
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < cols; j++)
                {
                    if (n <= 0)
                    {
                        if (matrix[i, j] == symbol)
                        {
                            Console.WriteLine($"({i}, {j})");
                            IsSymbol = true;
                            n++;
                            break;
                        }
                    }
                    
                }
            }

            if (!IsSymbol)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
