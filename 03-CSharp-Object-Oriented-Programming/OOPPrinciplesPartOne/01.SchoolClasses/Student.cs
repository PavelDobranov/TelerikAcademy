namespace SchoolClasses
{
    using System;

    using SchoolClasses.Interfaces;

    public class Student : Human, IStudent
    {
        private const string NegativeValueErrorMessage = "Non-negative number required";
        private const string ToStringFormatAddition = "Class number: {0}";

        private int classNumber;

        public Student(string name, Gender gender, int classNumber)
            : base(name, gender)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("classNumber", Student.NegativeValueErrorMessage);
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(ToStringFormatAddition, this.ClassNumber);
        }
    }
}