using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    //Capital I in the start of this interface is just a convention
    //note there is no class keyword instead we use interface key word
    public interface IAnimalInterface
    {
        //note that there is no access modifier 
        //we already know that all the members of an interface are public

        string TypeOfAnimal { get; set; }
        void feed();
        void speak();
    }
}
