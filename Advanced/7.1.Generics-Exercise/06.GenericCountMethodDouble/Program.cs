namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double[] strings = new double[count];

            for (int i = 0; i < count; i++)
            {
                strings[i] = double.Parse(Console.ReadLine());
            }

            double value = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(strings, value);

            int number = box.ReturnTheCountOfGreaterElements();

            Console.WriteLine(number);

        }
    }
}
