using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car()
        {
           //empty
        }



        //public Car(string model, Engine engine, int weight) : this(model, engine)
        //{
        //    this.Weight = weight;

        //}

        //public Car(string model, Engine engine, string color) : this(model, engine)
        //{
        //    this.Color = color;

        //}

        public Car(string model, Engine engine, int? weight, string? color) : this()
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public string Model { get; }
        public Engine Engine { get; private set; }
        public int? Weight { get; }
        public string? Color { get; }


        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();

            resultBuilder.AppendLine($"{this.Model}:");
            resultBuilder.AppendLine($"  {this.Engine.Model}:");
            resultBuilder.AppendLine($"    Power: {this.Engine.Power}");
            resultBuilder.AppendLine($"    Displacement: {this.Engine.Displacement?.ToString() ?? "n/a" }");
            resultBuilder.AppendLine($"    Efficiency: {this.Engine.Efficiency ?? "n/a" }");
            resultBuilder.AppendLine($"  Weight: {this.Weight?.ToString() ?? "n/a"}");
            resultBuilder.Append($"  Color: {this.Color ?? "n/a"}");

            return resultBuilder.ToString();
        }


    }
}

