namespace GenericBoxOfInteger
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

            foreach (Box<int> box in integers)
            {
                Console.WriteLine(box);
            }
        }
    }
}
