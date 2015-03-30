namespace Bank.Accounts
{
    using System;

    using Bank.Interfaces;

    public class LoanAccount : Account, IAccount, IDepositable
    {
        public LoanAccount(ICustomer customer)
            : base(customer)
        {
        }

        public override decimal InterestAmountForPeriod(int mounts)
        {
            if (mounts <= this.Customer.LoanAccountPeriod)
            {
                return 0;
            }

            return base.InterestAmountForPeriod(mounts - this.Customer.LoanAccountPeriod);
        }
    }
}