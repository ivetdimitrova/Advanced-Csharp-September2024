namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] information = Console.ReadLine().Split().ToArray();

                string continent = information[0];
                string country = information[1];
                string city = information[2];

                if (!continents.ContainsKey((continent)))
                {
                    continents.Add(continent,new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey((country)))
                {
                    continents[continent].Add(country,new List<string>());
                }

                continents[continent][country].Add(city);
            }


            foreach (var (continent, countries) in continents)
            {
                Console.WriteLine($"{continent}:");

                foreach (var (country, cities) in countries)
                {
                    Console.WriteLine($"{country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
