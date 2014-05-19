using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class SClassCar
    {
        public abstract int EliteLevel { get; }
        public abstract int MaxSpeed { get; }

        public abstract void EliteRide();
    }
}
