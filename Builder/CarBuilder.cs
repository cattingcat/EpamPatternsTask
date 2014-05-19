using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CarBuilder
    {
        public virtual void CreateCylinders(int count) { }
        public virtual void CreateWeels(int count) { }
        public virtual void CreateSeating(int count) { }
        public virtual void CreateGasolineTank(int volume) { }
        public virtual void CreateClimateControl() { }
    }
}
