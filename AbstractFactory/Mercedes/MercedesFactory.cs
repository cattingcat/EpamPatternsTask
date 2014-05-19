using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mercedes
{
    class MercedesFactory: CarsFactory
    {
        public override SClassCar CreateSClass()
        {
            return new MercedesS600();
        }

        public override Truck CreateTruck()
        {
            return new MercedesAltero();
        }
    }
}
