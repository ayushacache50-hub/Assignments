using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Assignment
{
     class BankAccount
    {
        protected int accountNumber;
        protected int password;
        protected double balance;

        public BankAccount(int accNo, int pass, double bal)
        {
            accountNumber = accNo;
            password = pass;
            balance = bal;
        }

        public bool Login(int accNo, int pass)
        {
            return accountNumber == accNo && password == pass;
        }
    }
}