using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<int> list = new List<int>();
            ICollection<int> coll = new LogDecorator(list);


            coll.Add(2);
            coll.Add(3);
            coll.Add(4);
            coll.Add(1);
            coll.Remove(2);
            bool flag = coll.IsReadOnly;

            Console.ReadKey();
        }
    }
}
