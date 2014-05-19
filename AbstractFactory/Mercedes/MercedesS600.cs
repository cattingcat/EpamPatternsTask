using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mercedes
{
    class MercedesS600: SClassCar
    {
        public override int EliteLevel
        {
            get { return 600; }
        }

        public override int MaxSpeed
        {
            get { return 260; }
        }

        public override void EliteRide()
        {
            Console.WriteLine("Yahoooo, im on mercedes!");
        }
    }
}
