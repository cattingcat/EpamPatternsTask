using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PersonAccessor: IAccessor<Person>
    {
        public ICollection<Person> Persons { get; set; }

        public IEnumerable<Person> SelectAll()
        {
            return Persons;
        }

        public Person SelectById(object id)
        {
            return (from p in Persons where p.Id == (int)id select p).SingleOrDefault();
        }

        public void Add(Person item)
        {
            Persons.Add(item);
        }

        public void Remove(Person item)
        {
            Persons.Remove(item);
        }
    }
}
