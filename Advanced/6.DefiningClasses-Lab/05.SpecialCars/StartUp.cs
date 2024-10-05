using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialCars
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
           List<Engine> engines = new List<Engine>();
           List<Car> cars = new List<Car>();

           string data;
           while ((data = Console.ReadLine()) != "No more tires")
           {
               string[] tiresData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

               Tire[] carTires = new Tire[tiresData.Length/2];
               int tireNumber = 0;
               for (int i = 0; i <= tiresData.Length - 2; i+=2)
               {
                   Tire tire = new Tire(int.Parse(tiresData[i]), double.Parse(tiresData[i+1]));
                   
                   carTires[tireNumber] = tire;
                   tireNumber++;
                }
               
               tires.Add(carTires);
           }

           while ((data = Console.ReadLine()) != "Engines done")
           {
                string[] engineData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Engine engine = new Engine(int.Parse(engineData[0]), double.Parse(engineData[1]));

                engines.Add(engine);
           }

           while ((data = Console.ReadLine()) != "Show special")
           {
                string[] carData = data.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex],
                    tires[tiresIndex]);

                cars.Add(car);

           }

            // 1st Option
            foreach (Car car in cars)
            {

                if (car.Year >= 2017 && car.Engine.HorsePower >= 330)
                {
                    double pressureSum = 0;
                    foreach (Tire tire in car.Tires)
                    {
                        pressureSum += tire.Pressure;
                    }

                    if (pressureSum >= 9 && pressureSum <=10)
                    {
                        car.Drive(20);

                        Console.WriteLine(car.WhoAmI());
                    }


                }
            }

            //2nd Option

            var filterCars = cars
               .Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(y => y.Pressure) >= 9 && car.Tires.Sum(y => y.Pressure) <= 10)
               .ToList();

            foreach (Car car in filterCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }

        }


    }
}
