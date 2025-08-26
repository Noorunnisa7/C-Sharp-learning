using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11
{
    class Account
    {
        // Account Holder  , Balance , widthdraw

        public string accountHolder;
        public double Balance;

        public Account(string name, double balance)
        {
            this.accountHolder = name;
            this.Balance = balance;
        }

        public virtual void widthDraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Account Holder: {accountHolder} ,WidthDraw: {amount} , Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }
        }

        // saving Account / Current Account

      
    }
    class SavingAccount : Account
    {
        public SavingAccount(string name, double balance) : base(name, balance) { }

        public override void widthDraw(double amount)
        {
            double fee = 10;

            amount = amount + fee;
            Console.WriteLine("------Saving Account-------");
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Account Holder: {accountHolder} ,WidthDraw: {amount} ,Remaining Balance: {Balance} ,Fee: {fee}");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }

        }

    }

    class CurrentAccount : Account
    {
        public CurrentAccount(string name, double balance) : base(name, balance) { }

        public override void widthDraw(double amount)
        {
            Console.WriteLine("--------Current Account-------");
            if (amount <= Balance)
            {
                Balance -= amount;
                
                Console.WriteLine($"Account Holder: {accountHolder} ,WidthDraw: {amount} , Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }
        }
    }

}
