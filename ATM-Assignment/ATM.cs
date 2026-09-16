using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Assignment
{
    class ATM : BankAccount
    {
        public ATM(int accNo, int pass, double bal)
            : base(accNo, pass, bal)
        {
        }
        public void ShowWithdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. ");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance. ");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Transaction Successful. ");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("Balance: " + balance);
        }
        public void ShowDeposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Amount deposited successfully. ");
                Console.WriteLine("\n 1. Chech updated balance.  ");
                Console.WriteLine("\n 2. Exit. ");
                Console.WriteLine("Enter the number of your choice. ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Balance: " + balance);
                    Console.WriteLine(" Have a great day, Press Any key to EXIT. ");
                }
                else
                {
                    Console.WriteLine(" Have a great day, Press Any key to EXIT. ");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. ");
            }
        }

    }
}
