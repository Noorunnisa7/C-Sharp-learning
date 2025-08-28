using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12
{
    class Program
    {
        interface IStudent
        {
            void studentDetails();
            void Courses();
        }

        class Student1 : IStudent
        {
            public void studentDetails()
            {
                Console.WriteLine("Name: Ali \n Age: 24");
            }
            public void Courses()
            {
                Console.WriteLine("Course: C# ");
            }
        }
        




        static void Main(string[] args)
        {
            //Animal a = new Animal();
            //a.Detail();

            Cat a = new Cat();
            a.Sound();

            Animal b = new Cat();
            b.Sound();
            b.COlor();

            Animal c = new Horse();
            c.Sound();
            c.COlor();

            IStudent std1 = new Student1();
            std1.studentDetails();
            std1.Courses();

            Console.ReadKey();
        }
    }
}
