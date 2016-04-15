using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Customer : ITestVehicle
    {
        string name;
        int ID;
        int testValue;
       

        public Customer()
        {
            this.name = "TestCustomer";
            this.ID = 123;
        }
        
        public void Test()
        {
            Random testDrive = new Random();
            testValue = testDrive.Next(0, 1);
            if(testValue == 0)
            {
                Console.WriteLine("customer does not like the vehicle");
            }
            else
            {
                Console.WriteLine("customer likes the vehicle.");
            }
        }
    }
}
