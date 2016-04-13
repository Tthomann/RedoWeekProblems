using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Flight
    {
        string destination;
        int flightNumber;
        string timeOfFlight;
        Flight flight;
        List<Flight> flightList;
        
        public Flight(string Destination, int FlightNumber, string TimeOfFlight)
        {
            this.destination = Destination;
            this.flightNumber = FlightNumber;
            this.timeOfFlight = TimeOfFlight;
        }

        public Flight()
        {
            flightList = new List<Flight>();
        }
        public void AddFlights()
        {
            flightList.Add(new Flight("Los Angeles", 728, "6:30am"));
            flightList.Add(new Flight("NewYork", 349, "7:20am"));
            flightList.Add(new Flight("Tenesee", 236, "8:15am"));
            flightList.Add(new Flight("Ohio", 958, "11:23am"));
            flightList.Add(new Flight("SouthCarolina", 471, "1:33pm"));
            flightList.Add(new Flight("Kentucky", 618, "12:44pm"));
        }
        public IEnumerator<Flight> GetEnumerator()
        {
            foreach(Flight flight in flightList)
            {
                yield return flight;

            }
            foreach(Flight flight in flightList)
            {
                if (flight.flightNumber == 728)
                {
                    Console.WriteLine("\r\n flight to take: ");
                }
                yield return flight;
                yield break;
            }
        }
        public override string ToString()
        {
            return "\r\n DESTINATION : " + destination + "\r\n FLIGHT NUMBER : " + flightNumber + "\r\n TIME OF FLIGHT: " + timeOfFlight;
        }
    }
    
}
