using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    interface IDependency
    {
        void Foo();
    }

    class ConcreteDependency : IDependency
    {
        public void Foo()
        {
            Console.WriteLine("Hello world!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IIocContainer ioc = null;
            Console.WriteLine("Select IoC container: 1 - Ninject, 2 - Unity, 3 - Windsor.");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ioc = new NinjectAdapter();
                    break;
                case 2:
                    ioc = new UnityAdapter();
                    break;
                case 3:
                    ioc = new WindsorAdapter();
                    break;
            }

            ioc.Register<IDependency, ConcreteDependency>();
            IDependency dependency = ioc.Resolve<IDependency>();
            dependency.Foo();

            Console.ReadKey();
        }
    }
}
