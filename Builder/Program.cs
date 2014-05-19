using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            EconomyCarBuilder cb = new EconomyCarBuilder();
            UserInputReader uir = new UserInputReader(cb);
            uir.Run();
            Console.WriteLine(cb.GetEconomyCar());

            EliteCarBuilder ecb = new EliteCarBuilder();
            UserInputReader euir = new UserInputReader(ecb);
            euir.Run();
            Console.WriteLine(ecb.GetEliteCar());

            Console.ReadKey();
        }
    }
}
