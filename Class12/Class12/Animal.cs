using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12
{
    abstract class Animal
    {
        public abstract void Sound();
        public abstract void COlor();
        public void Detail()
        {
            Console.WriteLine("Abstract Class and method");
            Console.WriteLine("This is Animal Class");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Cat Meows");
        }
        public override void COlor()
        {
            Console.WriteLine("Cat Color is Black");
        }
    }
    class Horse : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Horse ....");
        }
        public override void COlor()
        {
            Console.WriteLine("Horse Color is Brown");
        }
    }
}
