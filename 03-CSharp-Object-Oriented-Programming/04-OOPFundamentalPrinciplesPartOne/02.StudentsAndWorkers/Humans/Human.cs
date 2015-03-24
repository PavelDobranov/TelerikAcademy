namespace StudentsAndWorkers.Humans
{
    using System;

    using StudentsAndWorkers.Interfaces;

    public abstract class Human : IHuman
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string ToStringFormat = "First name: {0}, Last name: {1}";

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Human.ValidateName(value, "FirstName");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Human.ValidateName(value, "LastName");

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format(Human.ToStringFormat, this.FirstName, this.LastName);
        }

        private static void ValidateName(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException(Human.ValueNullOrEmptyErrorMessage, paramName);
            }
        }
    }
}