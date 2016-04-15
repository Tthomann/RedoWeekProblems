using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Toyota : Vehicle
    {
        
        string toyotaTag = "TOY";
        public Toyota(string ToyotaTag, int Price)
        {
            price = 5000;
            this.toyotaTag = ToyotaTag;
        }
        public Toyota()
        {

        }
    }
}
