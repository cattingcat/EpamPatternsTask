using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    class NinjectAdapter: IIocContainer
    {
        IKernel _ninject = new StandardKernel();

        public void Register<TFrom, TTo>() where TTo : TFrom
            where TFrom : class
        {
            _ninject.Bind<TFrom>().To<TTo>();
        }

        public T Resolve<T>() where T : class
        {
            return _ninject.Get<T>();
        }

        public void Register<T>(T instance) where T : class
        {
            _ninject.Bind<T>().ToConstant(instance);
        }
    }
}
