namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {

                string[] information = Console.ReadLine().Split(" -> ").ToArray();

                string colour = information[0];
                string[] clothes = information[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour,new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[j]))
                    {
                        wardrobe[colour].Add(clothes[j],0);
                    }

                    wardrobe[colour][clothes[j]]++;
                }
                
            }

            string[] searchClothing = Console.ReadLine().Split().ToArray();

           
            foreach (var (colour,clothes) in wardrobe)
            {
                Console.WriteLine($"{colour} clothes:");

                foreach (var (clothing, number) in clothes)
                {
                    if (colour == searchClothing[0] && clothing == searchClothing[1])
                    {
                        Console.WriteLine($"* {clothing} - {number} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {clothing} - {number}");
                }
            }
        }
    }
}
