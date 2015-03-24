namespace StudentsAndWorkers.Humans
{
    using System;

    using StudentsAndWorkers.Interfaces;

    public class Student : Human, IHuman, IStudent
    {
        private const string ValueLessOrEqualToZeroErrorMessage = "Cannot be less or equal to zero";
        private const string ToStringFormat = "{0}, Grade: {1}";

        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Garde", Student.ValueLessOrEqualToZeroErrorMessage);
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format(Student.ToStringFormat, base.ToString(), this.Grade);
        }
    }
}