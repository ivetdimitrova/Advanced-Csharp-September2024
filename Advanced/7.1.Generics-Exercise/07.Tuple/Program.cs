namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string fullName = $"{input[0]} {input[1]}";
            string address = input[2];
            Tuple<string, string> personInfo = new Tuple<string, string>(fullName, address);

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = input[0];
            int liters = int.Parse(input[1]);
            Tuple<string, int> amountOfBeer = new Tuple<string, int>(name, liters);

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int integer = int.Parse(input[0]);
            double double1 = double.Parse(input[1]);
            Tuple<int, double> numbers = new Tuple<int, double>(integer, double1);


            Console.WriteLine(personInfo);
            Console.WriteLine(amountOfBeer);
            Console.WriteLine(numbers);

        }
    }
}
