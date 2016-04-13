using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            Flight flights = new Flight();
            flights.AddFlights();
            foreach (Flight f in flights)
            {
                Console.WriteLine(f.ToString());
            }
            
            
            Console.ReadLine();
        }
    }
}
