namespace Bank.Accounts
{
    using System;

    using Bank.Common;
    using Bank.Interfaces;

    public class DepositAccount : Account, IAccount, IDepositable, IWithdrawable
    {
        private const int InterestReateMinimumBalance = 1000;

        public DepositAccount(ICustomer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public void Widthdraw(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException(string.Format(ErrorMessage.ValueLessOrEqualToZeroFormat, "Money"));
            }

            if (money > this.Balance)
            {
                throw new ArgumentException(string.Format(ErrorMessage.WithdrawMoreThanCurrentBalanceFormat, this.Balance));
            }

            this.Balance -= money;
        }

        public override decimal InterestAmountForPeriod(int mounts)
        {
            if (this.Balance < DepositAccount.InterestReateMinimumBalance)
            {
                return 0;
            }

            return base.InterestAmountForPeriod(mounts);
        }
    }
}