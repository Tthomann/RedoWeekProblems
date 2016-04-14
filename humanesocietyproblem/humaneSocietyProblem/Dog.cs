using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humaneSocietyProblem
{
   
    public class Dog
    {
        string dogName;
        int? dogAge = null;
        List<Dog> dogs;
        dogBreeds _dogBreeds;
        
        public Dog(string DogName, int DogAge, dogBreeds DogBreeds)
        {
            this._dogBreeds = DogBreeds;
            this.dogName = DogName;
            this.dogAge = DogAge;
        }
        public Dog()
        {
            Random random = new Random();
            dogs = new List<Dog>();
        }
        public void addDogs()
        {
            dogs.Add(new Dog("Pennie", 5, dogBreeds.bulldog));
            dogs.Add(new Dog("Daisy", 3, dogBreeds.labrador));
            dogs.Add(new Dog("Abby", 7, dogBreeds.malteese));
        }
        public IEnumerator<Dog> GetEnumerator()
        {

            foreach(Dog doggie in dogs)
            {
                yield return doggie;
            }     
        }
        public override string ToString()
        {
            return "dog name: " + dogName + "\r\ndog age: " + dogAge + "\r\ndog breed: " + _dogBreeds + "\r\n";
        }
    }
}
