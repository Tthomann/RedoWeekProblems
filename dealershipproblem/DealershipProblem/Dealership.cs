using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipProblem
{
    class Dealership : ITestVehicle
    {
        public List<object> Cars = new List<object>();
        public Dodge dodge = new Dodge();
        public Toyota toyota = new Toyota();
        public Yamaha yamaha = new Yamaha();
        private int safetyTestValue;
        private int userInput;
        int haggled;

        public Dealership()
        {

        }
        public void SalesEvent()
        {
            Console.WriteLine("all vehicles prices have been lowered by $1,000 due to the sales event.");
            toyota.price -= 1000;
            dodge.price -= 1000;
            yamaha.price -= 1000;
            
        }
        public void Haggle()
        {
            Random haggleThePrice = new Random();
            haggled = haggleThePrice.Next(0, 2);
            if (haggled == 0)
            {
                Console.WriteLine("the customer sucks at haggling, the price remains the same.");
              
            }
            else
            {
                Console.WriteLine("customer has successfully haggled the price of all cars -$200.");
                toyota.price -= 200;
                yamaha.price -= 200;
                dodge.price -= 200;

            }
        }
        public void sell()
        {
            Console.WriteLine("type 1 to sell a dodge vehicle");
            Console.WriteLine("type 2 to sell a toyota vehicle");
            Console.WriteLine("type 3 to sell a yamaha vehicle");
            userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1 && Cars.Count == 0)
            {
                Cars.Remove(dodge);
                Console.WriteLine("you've sold a dodge vehicle");
            }else if (userInput == 2 && Cars.Count == 0)
            {
                Cars.Remove(toyota);
                Console.WriteLine("you've sould a toyota vehicle");
            }else if(userInput == 3 && Cars.Count == 0)
            {
                Cars.Remove(yamaha);
                Console.WriteLine("you've sold a yamaha vehicle");
            }
            else if (Cars.Count <= 0)
            {
                Console.WriteLine("no cars to sell.");
            }
        }
        public void priceAdjust()
        {
            Console.WriteLine("");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("|____________________price adjust____________________|");
            Console.WriteLine("| type 1 to adjust the price of all dodge vehicles   |");
            Console.WriteLine("| type 2 to adjust the price of all toyota vehicles  |");
            Console.WriteLine("| type 3 to adjust the price of all yamaha vehicles  |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("");
            userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1)
            {
                dodge.price -= 500;
                Console.WriteLine("you've adjusted the price of dodge vehicles by -$500");
            }else if(userInput == 2)
            {
                toyota.price -= 500;
                Console.WriteLine("you've adjusted the price of toyota vehicles by -$500");
            }
            else if(userInput == 3)
            {
                yamaha.price -= 500;
                Console.WriteLine("you've adjusted the price of yamaha vehicles by -$500");
            }
            else
            {
                Console.WriteLine("no vehicle brand seleted to price adjust.");
            }

        }
        public void Test()
        {
            Random safetyTest = new Random();
            safetyTestValue = safetyTest.Next(0, 2);
            Console.WriteLine("select car brand to test.");
            userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    if (safetyTestValue == 0)
                    {
                        Cars.Remove(dodge);
                        Console.WriteLine("selected car didn't pass the safety test, removing car from the warehouse.");
                    }
                    else if (Cars.Count < 0)
                    {
                        Console.WriteLine("no cars to test");
                    }
                    else
                    {
                        Console.WriteLine("safety test passed, car is ready for sale");
                    }
                    break;
                case 2:
                    if (safetyTestValue == 0)
                    {
                        Cars.Remove(toyota);
                        Console.WriteLine("selected car didn't pass the safety test, removing car from the warehouse.");
                    } else if (Cars.Count < 0) { 
                          Console.WriteLine("no cars to test");
                    }
                    else
                    {
                        Console.WriteLine("safety test passed, car is ready for sale");
                    }
                    break;
                case 3:
                    if (safetyTestValue == 0)
                    {
                        Cars.Remove(yamaha);
                        Console.WriteLine("selected car didn't pass the safety test, removing car from the warehouse.");
                    }
                    else if (Cars.Count < 0)
                    {
                        Console.WriteLine("no cars to test");
                    }
                    else
                    {
                        Console.WriteLine("safety test passed, car is ready for sale");
                    }
                    break;
                    
            }
        
        }
        public void AddVehicle()
        {
                Console.WriteLine("");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("|____________________Add Vehicles____________________|");
                Console.WriteLine("|           type 1 to add dodge vehicles             |");
                Console.WriteLine("|           type 2 to add toyota vehicles            |");
                Console.WriteLine("|           type 3 to add yamaha vehicles            |");
                Console.WriteLine("|____________________________________________________|");
                Console.WriteLine("");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Cars.Add(new Dodge());
                    Console.WriteLine("a dodge vehicle has been added to the car warehouse.");
                    Console.WriteLine(Cars.Count.ToString());
                        break;
                    case 2:
                        Cars.Add(new Toyota());
                    Console.WriteLine("a toyota vehicle has been added to the car warehouse.");
                    break;
                    case 3:
                        Cars.Add(new Yamaha());
                    Console.WriteLine("a yamaha vehicle has been added to the car warehouse.");
                    break;
                }
            }

    }
  

    }

