namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops =
                new Dictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] shopInfo = input.Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                string shopName = shopInfo[0];
                string product = shopInfo[1];
                double price = double.Parse(shopInfo[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName,new Dictionary<string, double>());
                }

                if (!shops[shopName].ContainsKey(product))
                {
                    shops[shopName].Add(product,price);
                }
                //else
                //{
                //    shops[shopName][product] = price;
                //}
               
            }
               
            var sortedShops = shops.OrderBy(x=> x.Key);

            foreach (var (shop, products) in sortedShops)
            {
                Console.WriteLine($"{shop}->");

                foreach (var (product,price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
