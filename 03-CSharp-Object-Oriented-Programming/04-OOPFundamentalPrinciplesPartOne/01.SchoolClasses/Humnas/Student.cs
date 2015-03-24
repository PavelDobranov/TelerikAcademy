namespace SchoolClasses.Humans
{
    using System;

    using SchoolClasses.Interfaces;

    public class Student : Human, IHuman, IStudent, ICommentable
    {
        private const string ValueLessOrEqualToZeroErrorMessage = "Cannot be less or equal to zero";
        private const string ToStringFormat = "{0}, Class number: {1}";

        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ClassNumber", Student.ValueLessOrEqualToZeroErrorMessage);
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format(Student.ToStringFormat, base.ToString(), this.ClassNumber);
        }
    }
}