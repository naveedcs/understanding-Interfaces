using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    //Abstract Implementation of Animal Class note the abstract keyword
    public abstract class AbstractAnimalClass
    {
        //Holds the type of Animal for example Cat or Dog
        public string TypeOfAnimal { get; set; }
        //Constructor
        public AbstractAnimalClass(string type)
        {
            TypeOfAnimal = type;
        }
        //Feed method to feed the animal
        public void feed()
        {
            Console.WriteLine("Feeding Done");
        }
        //Everything else in this class is same as StandardAnimalClass
        //Except this method
        //We have declaired it but not implimented it
        //We have to make the class abstract because even if one member of class is abstract
        public abstract void speak();
        
    }
}
