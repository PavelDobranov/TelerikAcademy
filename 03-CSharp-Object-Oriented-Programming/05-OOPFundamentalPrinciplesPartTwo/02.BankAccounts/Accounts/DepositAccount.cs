namespace Bank.Accounts
{
    using System;

    using Bank.Common;
    using Bank.Interfaces;

    public class DepositAccount : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccount(ICustomer customer)
            : base(customer)
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
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.InterestAmountForPeriod(mounts);
        }
    }
}