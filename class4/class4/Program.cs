using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"For Loop\"");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} - fOR LOOP IN C#");
            }


            Console.WriteLine("\"While Loop\"");

            //  intailize
            //   while(condition){
            //     code....
            //    ++ , --
            //   }

            int k = 1;
            while (k >= -10)
            {
                Console.WriteLine($"{k} --- While loop");
                k--;
            }

            Console.WriteLine("\"Do While Loop\"");

            int n = 10;

            do
            {
                Console.WriteLine($"{n} Do while loop");
                n++;
            }
            while (n > 20);

            // break and continue
            Console.WriteLine("\n \" BREAK\"");

            for (int a = 1; a <= 10; a++)
            {
                if (a == 6)
                {
                    break;
                }

                Console.WriteLine($"{a} \t");
            }


            Console.WriteLine("\n \" CONTINUE\"");

            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;
                }

                Console.WriteLine($"{a} \t");
            }



            Console.WriteLine("\n \" While with break\"");

            while (true)
            {
                Console.Write("Enter a number from (1 to 10): ");
                int number =  Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("You Entered Wrong no");
                    break;
                }
                else if(number < 0)
                {
                    Console.WriteLine("You Entered Negative no (the iteration has been stopped)");
                    break;
                }
                else if(number > 10)
                {
                    Console.WriteLine($"You Entered {number} you can only enter number from 1 to 10 (loop stop)");
                    break;
                }
                else
                {
                    Console.WriteLine($"You Entered {number}");
                }
            }


            Console.ReadKey();
        }
    }
}
