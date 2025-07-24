using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment    Ctrl + k + c
            // Remove    Ctrl +k + U
            // Wrap text  Ctrl + E + W
            Console.WriteLine("C# Programming");  // Print Data in new line
            Console.Write("Hello .Net Frame Work");   // Print data in same line 

            //Console.ReadLine();  // Get User input 


            // Escape Sequence 
            // \' , \" , \n , \t

            Console.Write("\n");
            Console.WriteLine("\nThis is Me \'Noor Un Nisa\'");
            Console.WriteLine("Your Name:\tNoor Un Nisa");

            // Data types 
            // string , integer , bool , float, double  , array , object , char

            // datatype VariableName = VariableValue

            int number = 21;
            float float_number = 12.65f;
            double double_int = 12.45678;
            string user_name = "Aptech Teacher";
            string[] array = {"A" , "B" , "C" };
            char charac = 'F';
            object[] obj = { "A" , 121 , true };

            Console.WriteLine($"Interger: {number} ");
            Console.WriteLine($"FLoat: {float_number} ");
            Console.WriteLine($"Double: {double_int} ");
            Console.WriteLine($"String: {user_name} ");
            Console.WriteLine($"Array: {array[2]} ");
            Console.WriteLine($"Char: {charac} ");

            //Covert.ToInt32  convert string data into Integer

            Console.WriteLine("\n \n \"Mark Sheet\"");
            Console.WriteLine("Enter Your Name: ");
            string stdName =  Console.ReadLine();
            Console.WriteLine("Enter Your Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Eng: ");
            int eng =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Science: ");
            int science = Convert.ToInt32(Console.ReadLine());

            int total = maths + eng + science;

            Console.WriteLine($"Student Name: {stdName}");
            Console.WriteLine($"Maths Marks: {maths}");
            Console.WriteLine($"English Marks: {eng}");
            Console.WriteLine($"Science Marks: {science}");
            Console.WriteLine($"Total Marks: {total}");



            Console.ReadKey();   // Read console
        }
    }
}
