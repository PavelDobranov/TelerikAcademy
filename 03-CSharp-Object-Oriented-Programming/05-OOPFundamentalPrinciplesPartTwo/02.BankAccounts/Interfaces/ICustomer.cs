namespace Bank.Interfaces
{
    using Bank.Customers;

    public interface ICustomer
    {
        string Name { get; set; }

        CustomerType Type { get; }

        int LoanAccountPeriod { get; }
    }
}