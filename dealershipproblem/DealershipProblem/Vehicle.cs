using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Vehicle
    {
        public int _price;
        public Vehicle()
        {

        }
        public int price
        {
            get { return this._price; }
            set
            {
                this._price = value;
               
            }
           
        }
    }
}
