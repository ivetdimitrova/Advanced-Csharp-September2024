using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Car
{
    internal class StartUp
    {
        static void Main()
        {
            Car car = new Car("VM", "MK3", 1992);

            Console.WriteLine($"Make: {car.Make} \nModel: {car.Model} \nYear: {car.Year}");

        }
    }
}
