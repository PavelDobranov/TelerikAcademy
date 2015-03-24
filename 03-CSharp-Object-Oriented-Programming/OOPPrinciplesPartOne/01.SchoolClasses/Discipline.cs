namespace SchoolClasses
{
    using System;

    using SchoolClasses.Interfaces;

    public class Discipline : IDiscipline
    {
        private const string NegativeValueErrorMessage = "Non-negative number required";
        private const string NameNullOrEmptyErrorMessage = "Name cannot be null or empty";
        private const string ToStringFormat = "Name: {0}, Number of lectures: {1}, Number of exercises: {2}";

        private string name;
        private int lecturesCount;
        private int exercisesCount;

        public Discipline(string name, int lecturesCount, int exercisesCount)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.ExercisesCount = exercisesCount;
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
                    throw new ArgumentException("name", Discipline.NameNullOrEmptyErrorMessage);
                }

                this.name = value;
            }
        }

        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("lecturesCount", Discipline.NegativeValueErrorMessage);
                }

                this.lecturesCount = value;
            }
        }

        public int ExercisesCount
        {
            get
            {
                return this.exercisesCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("exercisesCount", Discipline.NegativeValueErrorMessage);
                }

                this.exercisesCount = value;
            }
        }

        public override string ToString()
        {
            return string.Format(Discipline.ToStringFormat, this.Name, this.LecturesCount, this.ExercisesCount);
        }
    }
}