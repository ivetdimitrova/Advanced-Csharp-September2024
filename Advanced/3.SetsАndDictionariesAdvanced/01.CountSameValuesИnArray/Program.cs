namespace _01.CountSameValuesИnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> countByNumber = new Dictionary<double,int>();

            foreach (double number in numbers)
            {
                if (!countByNumber.ContainsKey(number))
                {
                    countByNumber.Add(number,0);
                }

                countByNumber[number]++;
            }

            foreach (var (number, count) in countByNumber)
            {
                Console.WriteLine($"{number} - {count} times ");
            }
        }
    }
}
