using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10
{
    class Car
    {
        public string name;
        public string color;
        public int model;
        public void Title()
        {
            Console.WriteLine("Car Parent Class");
        }
    }

    class Audi : Car
    {
        public void Detail()
        {
            Console.WriteLine($"Car Name: {name} , Color: {color} , Model: {model}");
        }
    }

    class BMW : Car
    {
        public void Detail()
        {
            Console.WriteLine($"Car Name: {name} , Color: {color} , Model: {model}");
        }
    }
}
