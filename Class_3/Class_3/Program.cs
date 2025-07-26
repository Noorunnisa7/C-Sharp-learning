using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string pass = Console.ReadLine();


            //if(username == "nisa" && pass == "abc123")
            //{
            //    Console.WriteLine($"Welcome {username}");
            //}
            //else if
            //else
            //{
            //    Console.WriteLine("Invalid Username and password");
            //}

            // Short hand if else   ? --- ternary operator 
            // Condition < "" ? "true" : "false"

            string output = username == "admin" && pass == "123" ? "Login Successfully" : "Invalid Cedentials";

            Console.WriteLine(output);


            // Switch Case 
            Console.WriteLine("--------\"Calculator\"------");
            Console.Write("Enter Num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter any one operator(+ ,- , * , /): ");
            string opt = Console.ReadLine();

            string result = "";

            switch (opt)
            {
                case "+":
                    result = $"Result: {num1 + num2}";
                break;
                case "-":
                    result = $"Result: {num1 - num2}";
                break;
                case "*":
                    result = $"Result: {num1 * num2}";
                break;
                case "/":
                    result = $"Result: {num1 / num2}";
                break;
                default:
                    result = $"Result: Invalid Operator";
                break;
            }

            // break , continue   loop 
            // 1 to 5 
            // 4
            // 1 to 10 
            // 

            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
