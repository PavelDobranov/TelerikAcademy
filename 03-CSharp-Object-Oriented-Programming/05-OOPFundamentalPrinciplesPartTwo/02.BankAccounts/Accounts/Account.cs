namespace Bank
{
    using System;

    using Bank.Common;
    using Bank.Interfaces;

    public abstract class Account : IAccount, IDepositable
    {
        private const int InitialBalance = 0;
        private const int InitialInterestRate = 0;

        private ICustomer customer;
        private decimal interestRate;

        public Account(ICustomer customer)
        {
            this.Customer = customer;
            this.Balance = Account.InitialBalance;
            this.InterestRate = Account.InitialInterestRate;
        }

        public ICustomer Customer
        {
            get
            {
                // TODO:!!!
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException(string.Format(ErrorMessage.NullValueFormat, "Customer"));
                }

                this.customer = value;
            }
        }

        public decimal Balance { get; protected set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ValueLessThanZeroFormat, "Interest rate"));
                }

                this.interestRate = value;
            }
        }

        public void Deposite(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException(string.Format(ErrorMessage.ValueLessOrEqualToZeroFormat, "Money"));
            }

            this.Balance += money;
        }

        public virtual decimal InterestAmountForPeriod(int mounts)
        {
            if (mounts <= 0)
            {
                throw new ArgumentException(string.Format(ErrorMessage.ValueLessOrEqualToZeroFormat, "Mounts"));
            }

            return this.Balance * this.InterestRate * mounts;
        }
    }
}