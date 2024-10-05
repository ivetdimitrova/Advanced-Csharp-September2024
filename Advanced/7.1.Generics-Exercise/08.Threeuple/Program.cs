namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string fullName = $"{input[0]} {input[1]}";
            string address = input[2];
            string[] town = input.Skip(3).ToArray();
            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>(fullName, address, string.Join(" ", town));

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = input[0];
            int liters = int.Parse(input[1]);
            bool canDrink = input[2] == "drunk";
            Threeuple<string, int, bool> amountOfBeer = new Threeuple<string, int, bool>(name, liters, canDrink);

            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name2 = input[0];
            double bankBalance = double.Parse(input[1]);
            string bankName = input[2];
            Threeuple<string, double, string> bankAccount = new Threeuple<string, double, string>(name2, bankBalance, bankName);


            Console.WriteLine(personInfo);
            Console.WriteLine(amountOfBeer);
            Console.WriteLine(bankAccount);
        }
    }
}
