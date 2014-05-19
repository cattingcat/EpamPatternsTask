using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class EconomyCarBuilder: CarBuilder
    {
        private StringBuilder _description = new StringBuilder();

        public override void CreateCylinders(int count)
        {
            _description.AppendFormat("This car have {0} cylinders! ", count);
        }

        public override void CreateWeels(int count)
        {
            _description.AppendFormat("{0} square weels. ", count > 4 ? "Wow, so much " : count.ToString());
        }

        public override void CreateSeating(int count)
        {
            _description.AppendFormat("{0} seating... For what?! ", count - 1);
        }

        public override void CreateGasolineTank(int volume)
        {
            _description.AppendFormat("{0} gasoline in holey tank! ", volume);
        }

        public string GetEconomyCar()
        {
            return _description.ToString();
        }
    }
}
