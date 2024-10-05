
namespace _03.CarConstructors
{
    public class Car
    {

        public Car()
        {
            this.Make = "VM";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }

        public void Drive(double distance)
        {
            bool Can = ((FuelQuantity - distance * FuelConsumption) * 0.1) > 0;
            if (!Can)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return
                $"Make: {Make} \nModel: {Model} \nYear: {Year} \nFuelQuantity: {FuelQuantity} \nFuelConsumption: {FuelConsumption}";
        }

    }
}
