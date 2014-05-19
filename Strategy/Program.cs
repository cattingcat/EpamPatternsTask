using Strategy.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidator sv = new HardValidator();
            PasswordValidator pv = new PasswordValidator();

            Console.WriteLine(pv.IsCorrectPassword("as..44d"));
            pv.PasswordStrategy = sv;
            Console.WriteLine(pv.IsCorrectPassword("as..44d"));
            Console.WriteLine(pv.IsCorrectPassword("as..44dGG"));


            Console.ReadKey();
        }
    }
}
