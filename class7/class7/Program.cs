using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    class Program
    {

        string name = "OOP Programming";

        public void ProgramMethod()
        {
            Console.WriteLine("Object Oriented Programming");
        }

        static void Main(string[] args)
        {

            Program obj = new Program();

            Console.WriteLine(obj.name);



            Fruit fruit1 = new Fruit();
            Console.WriteLine($"Object 1 (Name: {fruit1.name}  Color: {fruit1.color}  Price: {fruit1.price})");

            Fruit fruit2 = new Fruit();
            fruit2.name = "Mango";
            Console.WriteLine($"Object 2 (Name: {fruit2.name}  Color: {fruit2.color}  Price: {fruit2.price})");

            Fruit fruit3 = new Fruit();
            fruit3.name = "Banana";
            fruit3.color = "Yellow";
            fruit3.price = 20;
            Console.WriteLine($"Object 3 (Name: {fruit3.name} Color: {fruit3.color} Price {fruit3.price})");
            fruit3.MyMethod();



            Fruit fruit4 = new Fruit();
            fruit4.MyMethod();



            Program obj2 = new Program();
            obj2.ProgramMethod();


            Console.WriteLine("\"Student Class\"");

            Student std1 = new Student();
            std1.name = "Raza";
            std1.age = "20";
            std1.address = "do min";
            std1.city = "Karachi";
            std1.Data();




            Student std2 = new Student();
            std2.name = "Haider";
            std2.age = "21";
            std2.address = "do min";
            std2.city = "Karachi";
            std2.Data();




            Student std3 = new Student();
            std3.name = "zara";
            std3.age = "19";
            std3.address = "do min";
            std3.city = "Karachi";
            std3.Data();




            //Console.WriteLine(name); --- Error
            Console.ReadKey();
        }
    }
}
