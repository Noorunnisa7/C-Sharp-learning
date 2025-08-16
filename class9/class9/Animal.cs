using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class9
{
    internal class Animal // base class
    {
        public string name;
        public string color;
        public string sound;

        private void Data()
        {
            Console.WriteLine("This is Parent Protected Method");
        }
    }

    class Dog : Animal // derived class
    {

        public void DerivedFun()
        {
            Console.WriteLine("This is Dog child Class");
        }

        public void AnimalData()
        {
            Console.WriteLine($" Name {name} , Color {color} , Sound {sound}");
        }
    }

    class Cat : Animal {
        public void AnimalData()
        {
            Console.WriteLine($" Name {name} , Color {color} , Sound {sound}");
        }

        public void catFun()
        {
            this.Data();
        }

    }

}
