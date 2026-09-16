using System;
 namespace ATM_Assignment
{   class program
    {

        static void Main()
        {
            ATM atm1 = new ATM(12345, 1234, 50000);
            ATM atm2 = new ATM(67890, 9999, 800000);

            Console.WriteLine("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Password: ");
            int pass = Convert.ToInt32(Console.ReadLine());
            if (atm1.Login(accNo, pass))
            {
                Console.WriteLine("\n 1. Check Balance");
                Console.WriteLine("\n 2. Withdraw");
                Console.WriteLine("\n 3. Deposit");
                Console.WriteLine("\n Enter Serial number of your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    atm1.ShowBalance();
                }
                else if (choice == 2)
                {

                    Console.WriteLine("Enter amount to withdraw :");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    atm1.ShowWithdraw(amount);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter amount to Deposite: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    atm1.ShowDeposit(amount);

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Account Number or Password.");
            }


            if ( atm2.Login(accNo, pass))
            {
                Console.WriteLine("\n 1. Check Balance");
                Console.WriteLine("\n 2. Withdraw"); 
                Console.WriteLine("\n 3. Deposit");
                Console.WriteLine("\n Enter Serial number of your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    atm2.ShowBalance();
                }
                else if (choice == 2)
                {

                    Console.WriteLine("Enter amount to withdraw :");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    atm2.ShowWithdraw(amount);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter amount to Deposite: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    atm2.ShowDeposit(amount);

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Account Number or Password.");
            }
        }
    }
    

}