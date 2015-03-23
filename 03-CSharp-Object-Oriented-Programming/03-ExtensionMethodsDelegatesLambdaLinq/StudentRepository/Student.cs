namespace DataRepository
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string AgeLessOrEqualToZeroErrorMessage = "Age cannot be less or equal to zero";
        private const string GroupNumberLessOrEqualToZeroErrorMessage = "Group number cannot be less or equal to zero";
        private const string MarkOutOfRangeErrorMessageFormat = "Mark was out of range. Should be between {0} and {1}";
        private const string ToStringFormat = "{0} {1}, Age: {2}, FN: {3}, Phone: {4}, Email: {5}, Group: {6}";
        private const int MarkMinValue = 2;
        private const int MarkMaxValue = 6;

        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private int groupNumber;
        private ICollection<int> marks;

        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<int>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.ValidateName(value, "FirstName");

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
                this.ValidateName(value, "LastName");

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age", Student.AgeLessOrEqualToZeroErrorMessage);
                }

                this.age = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Student.ValueNullOrEmptyErrorMessage, "FacultyNumber");
                }

                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Student.ValueNullOrEmptyErrorMessage, "Phone");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Student.ValueNullOrEmptyErrorMessage, "Email");
                }

                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(Student.GroupNumberLessOrEqualToZeroErrorMessage, "GroupNumber");
                }

                this.groupNumber = value;
            }
        }

        public ICollection<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
            private set
            {
                this.marks = value;
            }
        }

        public void AddMark(int mark)
        {
            if (mark < Student.MarkMinValue || mark > Student.MarkMaxValue)
            {
                throw new ArgumentOutOfRangeException("mark", string.Format(Student.MarkOutOfRangeErrorMessageFormat, Student.MarkMinValue, Student.MarkMaxValue));
            }

            this.marks.Add(mark);
        }

        public override string ToString()
        {
            return string.Format(Student.ToStringFormat, this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email, this.GroupNumber);
        }

        private void ValidateName(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException(Student.ValueNullOrEmptyErrorMessage, paramName);
            }
        }
    }
}