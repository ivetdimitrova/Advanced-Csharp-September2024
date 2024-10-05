using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Engine
    {
        public Engine(int power,int speed)
        {
            this.Power = power;
            this.Speed = speed;
        }

        public int Power { get; }
        public int Speed { get; }
    }
}
