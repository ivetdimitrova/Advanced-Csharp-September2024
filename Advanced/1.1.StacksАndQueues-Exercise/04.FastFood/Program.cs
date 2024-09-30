namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                int futureQuantity = quantity - orders.Peek();
                if (futureQuantity < 0 )
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }

                quantity -= orders.Dequeue();
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
