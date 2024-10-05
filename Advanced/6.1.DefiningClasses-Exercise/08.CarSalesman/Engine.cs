using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Engine
    {
        //public Engine(string model, int power)
        //{
        //    this.Model = model;
        //    this.Power = power;
        //}


        //public Engine(string model, int power, int displacement) : this(model, power)
        //{
        //    this.Displacement = displacement;

        //}

        public Engine() 
        {
            //empty
        }

        public Engine(string model, int power, int? displacement, string? efficiency) : this()
        {
            this.Model = model; 
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; }
        public int Power { get; }
        public int? Displacement { get; set; }
        public string? Efficiency { get; }
    }
}
