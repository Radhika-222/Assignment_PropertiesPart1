using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PropertiesPart1
{
    public class BankAccount
    {
        public int AccountNo { get; }

        public string AccountHolderName { get; set; }

        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccount(int accountNo, string accountHolderName)
        {
            this.AccountNo = accountNo;
            this.AccountHolderName = accountHolderName;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if(amount>0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited{amount}. New balance:{Balance}");

            }
            else
            {
                Console.WriteLine("Deposite amount must be greater than zero.");
            }
        }

        public void Withdraw(double amount)
        {
            if(amount>0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw{amount} New Balance{Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance");
            }
        }
    }
}
