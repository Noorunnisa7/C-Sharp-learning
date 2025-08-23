using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10
{
    // polymorphism   
    // poly many
    // morph form
    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The Animal Makes Sound");
        }
    }

    class Cat : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The Cat Meows");
        }
    }
    class Dog : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
}
