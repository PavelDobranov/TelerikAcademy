namespace SchoolClasses
{
    using System;

    using 

    public abstract class Human
    {
        private const string NameNullOrEmptyErrorMessage = "Name cannot be null or empty";
        private const string ToStringFormat = "Name: {0}, Gender: {1}";

        private string name;

        public Human(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("name", Human.NameNullOrEmptyErrorMessage);
                }

                this.name = value;
            }
        }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format(Human.ToStringFormat, this.Name, this.Gender);
        }
    }
}