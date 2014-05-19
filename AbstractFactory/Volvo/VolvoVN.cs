using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Volvo
{
    class VolvoVN: Truck
    {
        public override int Capacity
        {
            get { return 90; }
        }

        public override void Ride()
        {
            Console.WriteLine("Volvo working hard");
        }
    }
}
