namespace Bank.Customers
{
    using Bank.Interfaces;

    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            : base(name, CustomerType.Individual)
        {
        }
    }
}