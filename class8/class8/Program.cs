using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class8
{
    class Program
    {

        //string name;

        public Program()
        {
            Console.WriteLine("Program Constructor");
        }



        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program();

            //Student std1 = new Student();
            //std1.Data();

            //Student std2 = new Student();
            //std2.Data();


            Student student1 = new Student(2,"Haider" , "7F");
            student1.Data();


            Student student2 = new Student(3, "Zara");
            student2.Data();

            Console.WriteLine("\"Access Modifiers\"");

            Example ex1 = new Example(32, "Raza");

            ex1.RevealData();
            //   ex1.Id = 3;
            // ex1.name = "Ali";   error

            //Console.WriteLine($"{ex1.name}");   Error

            Console.ReadKey();
        }
    }
}
