namespace Bank.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Balance { get; }

        decimal InterestRate { get; }

        decimal InterestAmountForPeriod(int mounts);
    }
}