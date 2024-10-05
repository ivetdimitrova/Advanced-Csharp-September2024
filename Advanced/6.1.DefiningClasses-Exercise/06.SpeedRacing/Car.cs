using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Car
    { 
        public Car(string model, double fuelAmount, double fuelConsumptionPer1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumptionPer1Km;
        }

        public string Model { get; }
        public double FuelAmount {get; private set; }

        public double FuelConsumption { get; set; }

        public double TravelDistance { get; private set; }

        public void Drive(double distance)
        {
            double income = distance * FuelConsumption;
            if (income > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= income; 
                this.TravelDistance += distance;
            }
        }
    }
}
