using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CarExtension
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "VM";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }


    }
}
