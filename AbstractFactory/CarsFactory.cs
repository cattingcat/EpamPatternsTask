using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class CarsFactory
    {
        public abstract SClassCar CreateSClass();
        public abstract Truck CreateTruck();
    }
}
