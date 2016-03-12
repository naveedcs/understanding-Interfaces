using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    //Dog Class inherits StandardAnimalClass
    public class Dog : StandardAnimalClass
    {
        //Constructor
        public Dog(string type) :
            base(type) { }

        //Over rides the Speak Method
        public override void speak()
        {
            Console.WriteLine(TypeOfAnimal+ " : Woof Woof Woof");
        }


    }
}
