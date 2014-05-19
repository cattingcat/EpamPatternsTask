using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Actions
{
    class Say: IAction
    {
        public void Perform()
        {
            Console.WriteLine("Hi~");
        }
    }
}
