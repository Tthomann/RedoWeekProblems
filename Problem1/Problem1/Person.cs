using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Person
    {
        public string name;
        public string lastName;
        public int age;
        public string birthday;
       
        public Person(string Birthday)
        {
            birthday = Birthday;
         DateTime currentDateTime = DateTime.Today;
        DateTime birthDateTime = DateTime.Parse(Birthday);

        age = currentDateTime.Year - birthDateTime.Year;
        }
        public static Person operator +(Person informationA, int informationB)
        {
            informationA.age = informationA.age + informationB;
      
            return informationA;
        }
    }
}
