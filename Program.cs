using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PropertiesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(123456789, "Sam");
            account.Deposit(50000);
            account.Withdraw(10000);

            Console.WriteLine("Account Number:" +account.AccountNo);
            Console.WriteLine("Account Holder Name:"+account.AccountHolderName);
            Console.WriteLine("Current Balance:" +account.Balance);
            Console.ReadKey();
        }
    }
}
