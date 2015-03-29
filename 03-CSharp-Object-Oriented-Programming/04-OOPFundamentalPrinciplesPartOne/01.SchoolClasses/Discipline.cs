namespace SchoolClasses
{
    using System;

    using SchoolClasses.Interfaces;

    public class Discipline : IDiscipline, ICommentable
    {
        private const string NegativeValueErrorMessage = "Non-negative number required";
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string ToStringFormat = "{0}, Lectures: {1}, Exercises: {2}";

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
                    throw new ArgumentException(Discipline.ValueNullOrEmptyErrorMessage, "Name");
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
                    throw new ArgumentOutOfRangeException("LecturesCount", Discipline.NegativeValueErrorMessage);
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
                    throw new ArgumentOutOfRangeException("ExercisesCount", Discipline.NegativeValueErrorMessage);
                }

                this.exercisesCount = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format(Discipline.ToStringFormat, this.Name, this.LecturesCount, this.ExercisesCount);
        }
    }
}