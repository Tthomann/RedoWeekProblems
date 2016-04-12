using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("01/04/1996");
            person += 12; 
            Console.WriteLine(person.age);
            Console.ReadLine();
        }
    }
}
