using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PhoneAccessor: IAccessor<Phone>
    {
        public ICollection<Phone> Phones { get; set; }

        public IEnumerable<Phone> SelectAll()
        {
            return Phones;
        }

        public Phone SelectById(object id)
        {
            return (from p in Phones where p.Number == (string)id select p).SingleOrDefault();
        }

        public void Add(Phone item)
        {
            Phones.Add(item);
        }

        public void Remove(Phone item)
        {
            Phones.Remove(item);
        }
    }
}
