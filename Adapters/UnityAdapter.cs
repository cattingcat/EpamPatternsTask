using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    class UnityAdapter: IIocContainer
    {
        UnityContainer _uc = new UnityContainer();

        public void Register<TFrom, TTo>() where TTo : TFrom
            where TFrom : class
        {
            _uc.RegisterType<TFrom, TTo>();
        }

        public T Resolve<T>()where T : class
        {
            return _uc.Resolve<T>();
        }

        public void Register<T>(T instance)where T : class
        {
            _uc.RegisterInstance<T>(instance);
        }
    }
}
