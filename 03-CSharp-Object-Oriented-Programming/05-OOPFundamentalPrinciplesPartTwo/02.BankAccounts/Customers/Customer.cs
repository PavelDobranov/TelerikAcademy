namespace Bank.Customers
{
    using System;

    using Bank.Common;
    using Bank.Interfaces;

    public abstract class Customer : ICustomer
    {
        private string name;

        public Customer(string name, CustomerType type, int loanAccountPeriod)
        {
            this.Name = name;
            this.Type = type;
            this.LoanAccountPeriod = loanAccountPeriod;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(string.Format(ErrorMessage.StringNullOrEmptyFormat, "Name"));
                }

                this.name = value;
            }
        }

        public CustomerType Type { get; private set; }

        public int LoanAccountPeriod { get; private set; }
    }
}