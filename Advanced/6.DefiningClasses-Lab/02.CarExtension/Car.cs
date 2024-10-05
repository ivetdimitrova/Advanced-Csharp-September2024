using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _02.CarExtension
{
    public class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            bool Can = ((FuelQuantity - distance * FuelConsumption) * 0.1 )> 0;
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
