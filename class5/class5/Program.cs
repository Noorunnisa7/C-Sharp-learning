using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 1; i <=5; i++)
            //{
            //    Console.Write($"{i} -----");
            //    for (int j = 1; j <=10; j++)
            //    {
            //        Console.Write(j);
            //        Console.Write("\t");

            //    }
            //    Console.Write("\n");
            //}



            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=3; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }



            for(int i = 1; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            for (int i = 10; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }

            //  5 - 5 4 3 2 1
            //  4 - 4 3 2 1
            //  3 - 3 2 1
            //  2 - 2 1
            // 1 -  1


            //  .....1
            //  ....1 2
            //  ...1 2 3
            //  ..1 2 3 4
            //  .1 2 3 4 5

            for(int i = 1; i <=5; i++)
            {
                for (int s = 5; s>=i; s--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine("");
            }

            //char letter = 'A';
            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine( (char)((int)'A'+i));
            }

            Console.ReadKey();

        }
    }
}
