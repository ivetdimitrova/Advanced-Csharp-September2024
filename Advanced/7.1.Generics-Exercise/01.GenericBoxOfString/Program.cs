namespace GenericBoxOfString
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

            foreach (Box<string> box in strings)
            {
                Console.WriteLine(box);
            }

        }
    }
}
