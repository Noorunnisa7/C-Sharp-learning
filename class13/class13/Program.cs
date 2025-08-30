using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class13
{
    class Program
    {


        class Person
        {
            private string name;


            public string PersonName {
                get { return name; }
                set { name = value; }
            
            }

            public void Data()
            {
                Console.WriteLine($"Private data: {name}");
            }
        }


        class Animal
        {
            public string name { get; set; }
            public string color { get; set; }
        }



        static void Main(string[] args)
        {

            Person p = new Person();
            p.PersonName = "Ali Haider";

            Console.WriteLine($"{p.PersonName }");
            p.Data();


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};

            string[] stdName = { "Ali", "Zain", "Hassan" , "Raza" };

            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(stdName[1]);


            

            // foreach(array as value) ---- php
            // foreach(datatype variable in array) ---C#
            foreach(string std in stdName)
            {
                Console.WriteLine(std);
            }


            int[] count = new int[5];
            count[0] = 12;
            count[1] = 13;
            count[2] = 14;
            count[3] = 15;
            count[4] = 16;

            foreach (int c in count)
            {
                Console.WriteLine(c);
            }


            object[] StdData = { 1,"Ali" , "20" , 20.12 , 50.2};

            foreach (object s in StdData)
            {
                Console.Write($"{s} ");
            }


            var dataList = new List<dynamic>
            {
                new { name = "Ali" , age = 20 , classname = "5f"  },
                new { name = "Raza" , age = 18 , classname = "5f"  },
                new { name = "Zain" , age = 22 , classname = "5f"  }
            };

            foreach (var data in dataList)
            {
                Console.WriteLine($"NAme {data.name} , Age {data.age} , Class Name : {data.classname}");
            }




            var Animaldata = new List<Animal>
            {
                new Animal{ name = "Dog" , color = "black" },
                new Animal{ name = "Cat" , color = "white" },
                new Animal{ name = "Horse" , color = "brown" },

            };


            foreach (var animal in Animaldata)
            {
                Console.WriteLine($"Name:{animal.name} , Color: {animal.color}");
            }


            Console.ReadKey();
        }
    }
}
