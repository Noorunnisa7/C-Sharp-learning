using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    class Student
    {
        public string name = "No found";
        public string age = "No found";
        public string address = "No found";
        public string city = "No found";

        public void Data()
        {
            Console.WriteLine($"Name: {this.name} Age: {this.age} Address: {this.address} City: {this.city}");
        }

    }
}
