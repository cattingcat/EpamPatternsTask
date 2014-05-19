using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccessor<Person> personAcc = new PersonAccessor()
            {
                Persons = new List<Person>{
                    new Person(){Id=1, Name="qwe"},
                    new Person(){Id=2, Name="asd"},
                    new Person(){Id=3, Name="zxc"},
                    new Person(){Id=4, Name="rty"},
                }
            };

            IAccessor<Phone> phoneAcc = new PhoneAccessor()
            {
                Phones = new List<Phone>{
                    new Phone(){Number="11111111", OwnerId=1},
                    new Phone(){Number="11111112", OwnerId=1},
                    new Phone(){Number="11111113", OwnerId=2},
                    new Phone(){Number="11111114", OwnerId=2},
                    new Phone(){Number="11111115", OwnerId=3},
                    new Phone(){Number="11111116", OwnerId=4},
                }
            };

            // facade for two accessors
            PersonDb pdb = new PersonDb(personAcc, phoneAcc);

            foreach (var p in pdb.SelectPersonsWithPhones())
            {
                Console.Write("{0}: ", p.Name);

                foreach (var ph in p.Phones)
                {
                    Console.Write("{0}, ", ph.Number);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
