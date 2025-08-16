using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            //Console.WriteLine(std.username); // error 

            //std.Data();  // error
            std.RevealData();

            // Inheritance 


            Dog obj = new Dog();

            obj.DerivedFun();

            obj.name = "Dog";
            obj.color = "black";
            obj.sound = "bark";

            obj.AnimalData();

            Cat cat = new Cat();
            cat.name = "Tom";
            cat.color = "blue";
            cat.sound = "meow";
            cat.AnimalData();

            cat.catFun();
        }
    }
}
