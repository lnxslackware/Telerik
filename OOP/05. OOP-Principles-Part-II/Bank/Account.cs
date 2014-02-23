using System;

namespace Bank
{
    public abstract class Account : IDepositable
    {
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }


        public void Deposit(decimal depositSum)
        {
            if (depositSum < 0)
            {
                throw new InvalidOperationException("You cannot deposit a negative amount of money.");
            }

            this.Balance += depositSum;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return months * InterestRate * this.Balance;
        }
    }
}
