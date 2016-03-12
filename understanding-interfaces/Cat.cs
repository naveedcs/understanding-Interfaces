using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    public class Cat : AbstractAnimalClass
    {
        //Constructor
        public Cat(string type) :
            base(type) { }

        //Over rides the Speak Method
        //Remember this was not implimented in the Abstract Animal Class
        public override void speak()
        {
            Console.WriteLine(TypeOfAnimal + " : Meow Meow Meow");
        }
    }
}
