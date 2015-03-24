namespace SchoolClasses.Humans
{
    using System;

    using SchoolClasses.Interfaces;

    public abstract class Human : IHuman, ICommentable
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string ToStringFormat = "{0}: {1} {2}";

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

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format(Human.ToStringFormat, this.GetType().Name, this.FirstName, this.LastName);
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