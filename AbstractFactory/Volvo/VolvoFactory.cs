using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Volvo
{
    class VolvoFactory: CarsFactory
    {
        public override SClassCar CreateSClass()
        {
            return new VolvoS80();
        }

        public override Truck CreateTruck()
        {
            return new VolvoVN();
        }
    }
}
