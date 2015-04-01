namespace Bank
{
    using System;
    using System.Text;

    using Bank.Common;
    using Bank.Interfaces;

    public abstract class Account : IAccount, IDepositable
    {
        private const string ToStringFormat = "[{0,-20}] Customer: {1,-15} Balance: {2,-10:F2} Interest rate: {3,-5:P1}";
        private const int InitialBalance = 0;

        private ICustomer customer;
        private decimal interestRate;

        public Account(ICustomer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = Account.InitialBalance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer.Clone();
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

        public override string ToString()
        {
            string accountNamePascalCase = this.GetType().Name;

            return string.Format(Account.ToStringFormat, this.ParsePascalCaseText(accountNamePascalCase), this.Customer.Name, this.Balance, this.InterestRate);
        }

        public virtual decimal InterestAmountForPeriod(int mounts)
        {
            if (mounts <= 0)
            {
                throw new ArgumentException(string.Format(ErrorMessage.ValueLessOrEqualToZeroFormat, "Mounts"));
            }

            return mounts * this.Balance * this.InterestRate;
        }

        private string ParsePascalCaseText(string text)
        {
            StringBuilder result = new StringBuilder();

            char separator = ' ';

            for (int symbol = 0; symbol < text.Length; symbol++)
            {
                result.Append(text[symbol]);

                if (symbol < text.Length - 1 && char.IsUpper(text[symbol + 1]))
                {
                    result.Append(separator);
                }
            }

            return result.ToString();
        }
    }
}