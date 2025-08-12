using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class8
{
    class Example
    {
        private int Id = 10;
        private string name = "Ali"; 


        public Example(int id , string Name )
        {
            Id = id;
            name = Name;
        }

        public void RevealData()
        {
            Console.WriteLine($"id:{Id} , Name: {name}");
        }

    }
}
