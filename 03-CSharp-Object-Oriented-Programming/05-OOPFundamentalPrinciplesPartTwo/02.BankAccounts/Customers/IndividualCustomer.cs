namespace Bank.Customers
{
    using Bank.Interfaces;

    public class IndividualCustomer : Customer, ICustomer
    {
        private const int LoanAccountPeriod = 3;

        public IndividualCustomer(string name)
            : base(name, CustomerType.Individual, IndividualCustomer.LoanAccountPeriod)
        {
        }
    }
}