using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekForcast days = new WeekForcast();
            days.displayForcast();
            Console.ReadLine();
        }
    }
}
