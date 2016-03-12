using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("German Sheppherd");
            dog.speak();

            Cat cat = new Cat("Persian");
            cat.speak();

            Loin loin = new Loin("White Loin");
            loin.speak();
            Console.ReadKey();
        }
    }
}
