using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Animal a1 = new Animal();
            //a1.MakeSound();

            //Animal a2 = new Cat();
            //a2.MakeSound();

            //Animal a3 = new Dog();
            //a3.MakeSound();

            Console.WriteLine("Account Class");

            Account acc1 = new Account("Nisa", 5000);
            acc1.widthDraw(200);

            Account acc2 = new Account("Ali", 500);
            acc2.widthDraw(1000);

            Account acc3 = new SavingAccount("Zain" , 6000);
            acc3.widthDraw(5000);

            Account acc4 = new CurrentAccount("Noor", 1000);
            acc4.widthDraw(1000);
            Console.ReadKey();
        }
    }
}
