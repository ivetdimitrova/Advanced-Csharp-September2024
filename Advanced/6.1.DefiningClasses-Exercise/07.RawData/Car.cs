using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Car
    {
        
        public Car(string model, Engine engine,Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires =new List<Tire>(tires);
        }
        public string Model { get; }

        public Engine Engine { get; }
        public Cargo Cargo { get; }
        public  List<Tire> Tires { get; }

    }
}
