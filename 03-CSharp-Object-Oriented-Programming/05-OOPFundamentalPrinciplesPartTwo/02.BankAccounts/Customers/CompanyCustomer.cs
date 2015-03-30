namespace Bank.Customers
{
    using Bank.Interfaces;

    public class CompanyCustomer : Customer, ICustomer
    {
        private const int LoanAccountPeriod = 2;

        public CompanyCustomer(string name)
            : base(name, CustomerType.Company, CompanyCustomer.LoanAccountPeriod)
        {
        }

    }
}
