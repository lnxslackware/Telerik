using System;

namespace Bank
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("The months for the calculations are invalid");
            }

            if ((this.Customer == Customer.Individual) && months <= 6)
            {
                return 0;
            }

            if ((this.Customer == Customer.Company) && months <= 12)
            {
                return base.CalculateInterest(months) / 2;
            }

            if (this.Customer == Customer.Individual)
            {
                months -= 6;
            }
            else
            {
                return base.CalculateInterest(months - 12) + (base.CalculateInterest(12) / 2);
            }

            return base.CalculateInterest(months);
        }

        public void Deposit(decimal depositSum)
        {
            if (depositSum > 0)
            {
                this.Balance += depositSum;
            }
        }
    }
}
