using System;

namespace Bank
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Withdraw(decimal withdrawSum)
        {
            if (this.Balance < withdrawSum)
            {
                throw new InvalidOperationException("There are not enough money in the deposit account.");
            }
                this.Balance -= withdrawSum;
        }

        public override decimal CalculateInterest(int months)
        {

            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("The months for the calculations are invalid");
            }

            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
