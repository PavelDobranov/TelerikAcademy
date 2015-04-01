namespace Bank.Customers
{
    using Bank.Interfaces;

    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name, CustomerType.Company)
        {
        }
    }
}