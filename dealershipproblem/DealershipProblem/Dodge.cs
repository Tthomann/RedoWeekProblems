using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Dodge : Vehicle
    {
        public string dodgeTag = "DGE";
        public Dodge(string DodgeTag, int Price)
        {
            price = 5000;
            this.dodgeTag = DodgeTag;
        }
        public Dodge()
        {

        }
    }
}
