using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _04.CarEngineAndTires
{
    public class StartUp
    {
        static void Main()
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            //firstCar.Drive(100000);
            //Console.WriteLine(firstCar.WhoAmI());

            //secondCar.Drive(200);
            //Console.WriteLine(secondCar.WhoAmI());

            //thirdCar.Drive(2050);
            //Console.WriteLine(thirdCar.WhoAmI());

            Tire[] tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.0),
                new Tire(2,0.5),
                new Tire(2,2.3)
            };

            Engine engine = new Engine(560, 6300);

            Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
        }


    }
}
