using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mercedes
{
    class MercedesAltero: Truck
    {
        public override int Capacity
        {
            get { return 50; }
        }

        public override void Ride()
        {
            Console.WriteLine("Working hard on mercedes");
        }
    }
}
