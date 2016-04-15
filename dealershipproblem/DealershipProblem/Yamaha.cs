using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Yamaha : Vehicle
    {
        public string yamahaTag = "YMH";
        public Yamaha(string YamahaTag, int Price)
        {
            price = 3000;
            this.yamahaTag = YamahaTag;
        }
        public Yamaha()
        {

        }
    }
}
