namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                jaggedArray[i] = new long[i+1];

                jaggedArray[i][0] = 1;
                jaggedArray[i][jaggedArray[i].Length - 1] = 1;

                if (i > 1)
                {
                    for (int j = 1; j < jaggedArray[i].Length-1; j++)
                    {
                        jaggedArray[i][j] = jaggedArray[i - 1][j] + jaggedArray[i - 1][j - 1];
                    }
                }
            }


            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
