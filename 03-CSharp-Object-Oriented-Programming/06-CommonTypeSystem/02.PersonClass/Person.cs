namespace PersonClass
{
    using System;
    using System.Text.RegularExpressions;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Regex rgx = new Regex(@"^[A-Z][a-z]{2,}$");
                string errMsg = "First name must contains atleast three letters, must start with a UPPERCASE letter and can only contain letters";

                if (rgx.IsMatch(value) == false)
                {
                    throw new ArgumentException(errMsg);
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than zero");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Name: {0}, Age: {1}", this.Name, this.Age);

            if (this.Age == null)
            {
                return result + "not specified";
            }
            else
            {
                return result;
            }
        }
    }
}