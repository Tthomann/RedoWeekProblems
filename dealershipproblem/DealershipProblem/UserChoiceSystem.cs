using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class UserChoiceSystem
    {
        Dealership dealership = new Dealership();
        Customer customer = new Customer();
        int choiceInput;
        int i = 0;
        public UserChoiceSystem()
        {

        }

        public void runProgram()
        {

            while (i < 10)
            {
                Console.WriteLine("");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("|_________________Dealership Program_________________|");
                Console.WriteLine("|             (1) dealership add vehicle             |");
                Console.WriteLine("|             (2) dealership adjust prices           |");
                Console.WriteLine("|             (3) dealership initiate sales event    |");
                Console.WriteLine("|             (4) dealership haggle with customer    |");
                Console.WriteLine("|             (5) dealership test vehicle            |");
                Console.WriteLine("|             (6) customer test vehicle              |");
                Console.WriteLine("|             (7) dealership sell vehicle            |");
                Console.WriteLine("|____________________________________________________|");
                Console.WriteLine("");
                choiceInput = Convert.ToInt32(Console.ReadLine());
                switch (choiceInput)
                {
                    case 1:
                        dealership.AddVehicle();
                        break;
                    case 2:
                        dealership.priceAdjust();
                        break;
                    case 3:
                        dealership.SalesEvent();
                        break;
                    case 4:
                        dealership.Haggle();
                        break;
                    case 5:
                        dealership.Test();
                        break;
                    case 6:
                        customer.Test();
                        break;
                    case 7:
                        dealership.sell();
                        break;
                }
            }
       
        }

    }
}
