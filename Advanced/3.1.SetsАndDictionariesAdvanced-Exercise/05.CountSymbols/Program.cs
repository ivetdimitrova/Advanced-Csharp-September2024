namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char,int> countBySymbol = new Dictionary<char,int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!countBySymbol.ContainsKey(text[i]))
                {
                    countBySymbol.Add(text[i],0);
                }

                countBySymbol[text[i]]++;
            }

            var sortedDictionary = countBySymbol.OrderBy(x => x.Key);

            foreach (var (symbol,count) in sortedDictionary)
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
