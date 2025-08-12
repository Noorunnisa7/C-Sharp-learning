using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class8
{
    class Student
    {
        public int Id;
        public string name;
        public string batch;


        //public Student()
        //{
        //    Id = 1;
        //    name = "Ali";
        //    batch = "5F";
        //}


        public Student(int id , string name , string batch = "1F")
        {
            this.Id = id;
            this.name = name;
            this.batch = batch;
        }
        public void Data()
        {
            Console.WriteLine($"ID:{Id} Name: {name} Batch: {batch}");
        }


        // 4 pillars Encapsulation , Inheritance , polymorphism and abstraction  
    }
}
