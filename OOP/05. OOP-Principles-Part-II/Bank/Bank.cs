using System;

namespace Bank
{
    class Bank
    {
        static void Main()
        {
            //Creating a new Deposit account
            DepositAccount myDeposit = new DepositAccount(Customer.Individual, 300M, 0.4M);
            
            //Calculating the interest for myDeposit
            Console.WriteLine(myDeposit.CalculateInterest(12));

            //Depositing some moneyZ into my account
            myDeposit.Deposit(1700);

            //Calculating the interest again
            Console.WriteLine(myDeposit.CalculateInterest(10));

            //Withdrowing some ca$h
            myDeposit.Withdraw(1000);

            //Printing the balance
            Console.WriteLine(myDeposit.Balance);
        }
    }
}
