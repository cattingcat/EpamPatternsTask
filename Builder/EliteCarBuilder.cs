using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class EliteCarBuilder: CarBuilder
    {
        private StringBuilder _description = new StringBuilder();

        public override void CreateCylinders(int count)
        {
            _description.AppendFormat("This car have {0} best cylinders! ", count);
        }

        public override void CreateWeels(int count) 
        {
            _description.AppendFormat("{0} good weels. ", count > 4 ? "Wow, so much " : count.ToString()); 
        }

        public override void CreateSeating(int count) 
        {
            _description.AppendFormat("You can ride with {0} your friends! ", count - 1);
        }

        public override void CreateGasolineTank(int volume) 
        {
            _description.AppendFormat("{0} gasoline is very much! ", volume);
        }

        public override void CreateClimateControl() 
        {
            _description.AppendFormat("Yahoooo :3 ");
        }

        public string GetEliteCar()
        {
            return _description.ToString();
        }
    }
}
