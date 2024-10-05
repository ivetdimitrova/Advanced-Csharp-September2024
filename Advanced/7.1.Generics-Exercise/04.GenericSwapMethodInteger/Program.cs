namespace GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int>[] integers = new Box<int>[count];

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                integers[i] = new Box<int>(number);
            }

            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            integers = Swap(integers, indexes[0], indexes[1]);

            foreach (Box<int> box in integers)
            {
                Console.WriteLine(box);
            }
        }

        private static Box<T>[] Swap<T>(Box<T>[] array, int index1, int index2)
        {
            Box<T> value = array[index1]!;
            array[index1] = array[index2];
            array[index2] = value;

            return array;

        }
    }
}
