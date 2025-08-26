using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Make Sounds");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Cat Meows");
        }
    }


    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Dog Barks");
        }
    }


}
