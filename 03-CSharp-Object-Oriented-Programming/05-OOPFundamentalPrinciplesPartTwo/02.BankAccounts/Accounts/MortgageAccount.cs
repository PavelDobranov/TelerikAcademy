namespace Bank.Accounts
{
    using Bank.Interfaces;
    using Bank.Customers;

    public class MortgageAccount : Account, IAccount, IDepositable
    {
        private const int IndividualCustomerNoInterestReatePeriodMonths = 6;
        private const int CompanyCustomerHalfInterestReatePeriodMonths = 12;

        public MortgageAccount(ICustomer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public override decimal InterestAmountForPeriod(int mounts)
        {
            if (this.Customer.Type == CustomerType.Individual && mounts > MortgageAccount.IndividualCustomerNoInterestReatePeriodMonths)
            {
                return base.InterestAmountForPeriod(mounts - MortgageAccount.IndividualCustomerNoInterestReatePeriodMonths);
            }

            if (this.Customer.Type == CustomerType.Company)
            {
                if (mounts <= MortgageAccount.CompanyCustomerHalfInterestReatePeriodMonths)
                {
                    return base.InterestAmountForPeriod(mounts) / 2;
                }
                else
                {
                    decimal halfPeriodInterestRate = base.InterestAmountForPeriod(MortgageAccount.CompanyCustomerHalfInterestReatePeriodMonths) / 2;
                    decimal fullPeriodInterestRate = base.InterestAmountForPeriod(mounts - MortgageAccount.CompanyCustomerHalfInterestReatePeriodMonths);

                    return halfPeriodInterestRate + fullPeriodInterestRate;
                }
            }

            return 0;
        }
    }
}