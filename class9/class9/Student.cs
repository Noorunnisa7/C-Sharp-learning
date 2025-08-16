using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class9
{
    internal class Student
    {
        protected string username = "Nisa";

        protected void Data()
        {
            Console.WriteLine($"User Name: {username}");
        }

        public void RevealData()
        {
            this.Data();
        }
    }
}
