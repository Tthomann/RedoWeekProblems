using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumProblem
{
    class WeekForcast
    {
        enum daysOfTheWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        enum weatherForTheWeek { Sunny, Rain, Storms, Overcast, Cloudy, Windy, Clear}
        public WeekForcast()
        {
            
        }
          public void displayForcast()
        {
            Console.WriteLine(daysOfTheWeek.Sunday + ":{0}", weatherForTheWeek.Sunny);
            Console.WriteLine(daysOfTheWeek.Monday + ":{0}", weatherForTheWeek.Rain);
            Console.WriteLine(daysOfTheWeek.Tuesday + ":{0}", weatherForTheWeek.Storms);
            Console.WriteLine(daysOfTheWeek.Wednesday + ":{0}", weatherForTheWeek.Overcast);
            Console.WriteLine(daysOfTheWeek.Thursday + ":{0}", weatherForTheWeek.Cloudy);
            Console.WriteLine(daysOfTheWeek.Friday + ":{0}", weatherForTheWeek.Windy);
            Console.WriteLine(daysOfTheWeek.Saturday + ":{0}", weatherForTheWeek.Clear);
        }
    }
}
       