using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    //it looks like Loin inherits from IAnimalInterface
    //but when we do interface it actually impliments it
    public class Loin : IAnimalInterface
    {
        //Implementation of TypeOfAnimal Property
        public string TypeOfAnimal { get; set; }
        
        public Loin(string type)
        {
            TypeOfAnimal = type;
        }
        //Implementation of feed method
        public void feed()
        {
            Console.WriteLine("Feeding is Done");
        }
        //Implementation of speak method
        public void speak()
        {
            Console.WriteLine(TypeOfAnimal + " : roar roar roar");
        }
    }
}
