using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsFactory volvo = new Volvo.VolvoFactory();
            CarsFactory mercedes = new Mercedes.MercedesFactory();

            Truck vTruck = volvo.CreateTruck();
            SClassCar vSClass = volvo.CreateSClass();

            Truck mTruck = mercedes.CreateTruck();
            SClassCar mSClass = mercedes.CreateSClass();

            vTruck.Ride();
            mTruck.Ride();

            mSClass.EliteRide();
            vSClass.EliteRide();

            Console.ReadKey();
        }
    }
}
