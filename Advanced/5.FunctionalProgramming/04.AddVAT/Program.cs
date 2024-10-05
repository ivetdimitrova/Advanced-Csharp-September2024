
using System.Diagnostics;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            double[] pricesWithVAT = AddVAT(prices);

            foreach (double price in pricesWithVAT)
            {
                Console.WriteLine($"{price:f2}");
            }
        }

        public static double[] AddVAT(double[] prices)
        {

            for (int i = 0; i < prices.Length; i++)
            {
                double increase = prices[i] * 0.2;
                prices[i] = prices[i] + increase;
            }

            return prices;
        }
    }
}
