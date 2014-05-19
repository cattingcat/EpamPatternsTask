using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Actions
{
    class Go: IAction
    {
        public void Perform()
        {
            Console.WriteLine("toof toof");
        }
    }
}
