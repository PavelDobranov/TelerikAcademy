namespace Bank.Accounts
{
    using System;

    using Bank.Customers;
    using Bank.Interfaces;

    public class LoanAccount : Account, IAccount, IDepositable
    {
        private const int IndividualCustomerNoInterestReatePeriodMonths = 3;
        private const int CompanyCustomerNoInterestReatePeriodMonths = 2;

        public LoanAccount(ICustomer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public override decimal InterestAmountForPeriod(int mounts)
        {
            if (this.Customer.Type == CustomerType.Individual && mounts > LoanAccount.IndividualCustomerNoInterestReatePeriodMonths)
            {
                return base.InterestAmountForPeriod(mounts - LoanAccount.IndividualCustomerNoInterestReatePeriodMonths);
            }

            if (this.Customer.Type == CustomerType.Company && mounts > LoanAccount.CompanyCustomerNoInterestReatePeriodMonths)
            {
                return base.InterestAmountForPeriod(mounts - LoanAccount.CompanyCustomerNoInterestReatePeriodMonths);
            }

            return 0;
        }
    }
}