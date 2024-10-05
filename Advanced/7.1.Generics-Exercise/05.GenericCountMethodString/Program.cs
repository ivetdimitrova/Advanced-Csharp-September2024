using System.Xml.Linq;

namespace GenericCountMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] strings = new string[count];

            for (int i = 0; i < count; i++)
            {
                strings[i] = Console.ReadLine();
            }

            string value = Console.ReadLine();

            Box<string> box = new Box<string>(strings, value);

            int number = box.ReturnTheCountOfGreaterElements();

            Console.WriteLine(number);

        }

    }
}
