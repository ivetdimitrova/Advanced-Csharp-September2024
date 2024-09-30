

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[numberOfRows ][];

            for (int i = 0; i < numberOfRows ; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string commandInput;
            while ((commandInput = Console.ReadLine()) != "END")
            {
                string[] commandParts = commandInput.Split().ToArray();

                string operation = commandParts[0];
                int targetRow = int.Parse(commandParts[1]);
                int targetColumn = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                bool areValidCoordinates = AreCoordinatesValid(targetRow, targetColumn , jaggedArray);

                if (areValidCoordinates)
                {
                    switch (operation)
                    {
                        case "Add":
                            jaggedArray[targetRow][targetColumn ] += value;
                            break;
                        case "Subtract":
                            jaggedArray[targetRow][targetColumn ] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            for (int i = 0; i < numberOfRows ; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static bool AreCoordinatesValid(int row, int column, int[][] matrix)
        {
            bool isValid = false;
            if (column >= 0 && row >= 0 && matrix.Length - 1 >= row)
            {
                int[] rowArray = matrix[row];
                if (rowArray .Length - 1 >= column)
                {
                    isValid  = true;
                }
            }

            return isValid ;
        }
    }
}
