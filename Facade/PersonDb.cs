using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PersonDb
    {
        private IAccessor<Person> _persons;
        private IAccessor<Phone> _phones;

        public PersonDb(IAccessor<Person> persons, IAccessor<Phone> phones)
        {
            _persons = persons;
            _phones = phones;
        }

        public IEnumerable<Person> SelectPersonsWithPhones()
        {
            IEnumerable<Person> persons = _persons.SelectAll();
            foreach (var p in persons)
            {
                p.Phones = from phone in _phones.SelectAll() where phone.OwnerId == p.Id select phone;
            }
            return persons;
        }
    }
}
