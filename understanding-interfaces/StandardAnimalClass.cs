using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    //Standard or Concrete Class
    public class StandardAnimalClass
    {
        //Holds the type of Animal for example Cat or Dog
        public string TypeOfAnimal { get; set; }
        //Constructor
        public StandardAnimalClass(string type)
        {
            TypeOfAnimal = type;
        }
        //Feed method to feed the animal
        public void feed()
        {
            Console.WriteLine("Feeding Done");
        }
        //This method is virtual because we will over load this method
        //in child classes
        public virtual void speak()
        {
            //Not Implimented
        }
    }
}
