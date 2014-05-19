using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IAccessor<T>
    {
        IEnumerable<T> SelectAll();
        T SelectById(object id);
        void Add(T item);
        void Remove(T item);
    }
}
