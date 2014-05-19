using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Truck
    {
        public abstract int Capacity { get; }

        public abstract void Ride();
    }
}
