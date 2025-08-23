using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10
{
    class Program
    {
        static void Main(string[] args)
        {

            Audi car = new Audi();
            car.name = "Audi";
            car.color = "black";
            car.model = 2000;
            car.Title();
            car.Detail();


            BMW car2 = new BMW();
            car2.name = "BMW";
            car2.color = "black";
            car2.model = 2002;
            car2.Title();
            car2.Detail();

            Console.WriteLine("POLY MORPHISM");

            Animal animal = new Animal();
            animal.animalSound();

            Cat cat = new Cat();
            cat.animalSound();

            Dog dog = new Dog();
            dog.animalSound();


            Console.ReadKey();

        }
    }
}
