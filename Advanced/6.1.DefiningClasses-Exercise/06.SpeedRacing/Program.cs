namespace _06.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumptionPer1Km = double.Parse(data[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPer1Km);

                cars[car.Model] = car;
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = data[1];
                double distance = double.Parse(data[2]);

                cars[model].Drive(distance);
            }

            foreach (var (model, car) in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
            }
        }
    }
}
