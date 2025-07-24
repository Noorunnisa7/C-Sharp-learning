using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Programming"); // Print Data
            Console.Write("Hello World");
            Console.WriteLine(".Net FrameWork");

            Console.WriteLine("Enter Your First Name:");
            string firstName =  Console.ReadLine();

            Console.WriteLine("Enter Your Last Name:");
            string lastName =  Console.ReadLine();

            //  DataType  VariableName = Value;

            //Console.WriteLine("My Name Is "+firstName);

            Console.WriteLine($"My Name is {firstName} {lastName}");
            Console.ReadKey(); // Read Console Data
        }
    }
}
