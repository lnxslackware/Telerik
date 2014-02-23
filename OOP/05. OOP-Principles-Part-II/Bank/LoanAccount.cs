using System;

namespace Bank
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("The months for the calculations are invalid");
            }

            if ((this.Customer == Customer.Individual) && months <= 3)
            {
                return 0;
            }

            if ((this.Customer == Customer.Company) && months <= 2)
            {
                return 0;
            }

            if (this.Customer == Customer.Individual)
            {
                months -= 3;
            }
            else
            {
                months -= 2;
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
