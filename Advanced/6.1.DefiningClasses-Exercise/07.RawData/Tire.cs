using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tire
    {
        public Tire( double pressure, int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        public int Age { get; }
        public double Pressure { get; }
    }
}
