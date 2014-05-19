using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class UserInputReader
    {
        private CarBuilder _builder;

        public UserInputReader(CarBuilder builder)
        {
            _builder = builder;
        }

        public void Run()
        {
            Console.WriteLine("please, enter cylinders count, weels count, seating count, gasoline tank volume, climte cintrol(1|0)");
            string[] args = Console.ReadLine().Split(' ');

            _builder.CreateCylinders(int.Parse(args[0]));
            _builder.CreateWeels(int.Parse(args[1]));
            _builder.CreateSeating(int.Parse(args[2]));
            _builder.CreateGasolineTank(int.Parse(args[3]));
            if (int.Parse(args[4]) == 1)
                _builder.CreateClimateControl();
        }
    }
}
