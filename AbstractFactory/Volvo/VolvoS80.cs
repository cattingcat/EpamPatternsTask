using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Volvo
{
    class VolvoS80: SClassCar
    {
        public override int EliteLevel
        {
            get { return 400; }
        }

        public override int MaxSpeed
        {
            get { return 240; }
        }

        public override void EliteRide()
        {
            Console.WriteLine("Elite ride on volvo!");
        }
    }
}
