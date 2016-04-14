using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humaneSocietyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogs = new Dog();
            dogs.addDogs();
            foreach(Dog dog in dogs)
            {
                Console.WriteLine(dog.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
