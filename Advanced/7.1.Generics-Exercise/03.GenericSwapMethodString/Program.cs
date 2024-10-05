namespace GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<string>[] strings = new Box<string>[count];

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                strings[i] = new Box<string>(text);
            }

            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            strings = Swap(strings, indexes[0], indexes[1]);

            foreach (Box<string> box in strings)
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
