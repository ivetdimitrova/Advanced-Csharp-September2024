namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ").ToArray();

                string operation = command[0];
                string carNumber = command[1];

                switch (operation)
                {
                    case "IN":
                        parking.Add(carNumber);
                        break;
                    case "OUT":
                        parking.Remove(carNumber);
                        break;
                }

            }

            if (parking.Count > 0)
            {
                foreach(string carNumber in parking)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
