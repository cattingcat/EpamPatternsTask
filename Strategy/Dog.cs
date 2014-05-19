using Strategy.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Dog
    {
        public IAction Action { get; set; }

        public Dog()
        {
            Action = new Say();
        }

        public void DoIt()
        {
            Console.WriteLine("Dog perform action ");
            Action.Perform();
        }
    }
}
