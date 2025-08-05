using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    class Program
    {
        static void myMethod()
        {
            Console.WriteLine("This is C# Static Method");
        }

        static void hello()
        {
            Console.WriteLine("Hello World");
        }


        static void StudentData(string fname , int age)
        {
            Console.WriteLine($"Name {fname} , Age {age}");
        }


        static void Users(string fname = "Not Found", int age = 0 , string country = "Not Found" )
        {
            Console.WriteLine($"Name {fname} , Age {age} , Country {country}" );
        }


        static int Sum(int a , int b)
        {
            int c = a + b;
            return c;
        }

        static string Data()
        {
            return "Hello C# Programming";
        }



        static void students(string std1 , string std2 , string std3)
        {
            Console.WriteLine($"Second Student : {std2}");
        }


        

        static void Add()
        {
            Console.WriteLine("This is no parameter Function");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"a {a} b {b}");
        }

        static void Add(double a , double b)
        {
            Console.WriteLine($"Double a {a}, Double b {b}");
        }

        static void Main(string[] args)
        {

            //code.....

            myMethod();
            hello();

            StudentData("Ali" , 20);
            StudentData("Raza", 23);

            Users("Basit", 12, "Pakistan");
            Users();
            Users("Noor" , 20);
            Console.Write(Sum(10,13));

            Console.WriteLine(Data());
            StudentData(age:20, fname: "Ali");

            students(std1:"Raza" ,std3: "Haider" , std2: "Zain");


            Add();
            Add(20,80);
            Add(20.65 ,10);
            Add(20, 12.1);
            //Add("10" , "32")

            Console.ReadKey();
        }
    }
}
