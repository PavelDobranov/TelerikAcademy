namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    using SchoolClasses.Interfaces;

    public class School : ISchool
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string ClassNullErrorMessage = "School class cannot be null";
        private const string ToStringFormat = "School: {0}";

        private string name;
        private ICollection<IClass> classes;

        public School(string name, ICollection<IClass> classes = null)
        {
            this.Name = name;
            this.Classes = classes;
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
                    throw new ArgumentException(School.ValueNullOrEmptyErrorMessage, "Name");
                }

                this.name = value;
            }
        }

        public ICollection<IClass> Classes
        {
            get 
            {
                return new List<IClass>(this.classes);
            }
            private set
            {
                if (value == null)
                {
                    this.classes = new List<IClass>();
                }
                else
                {
                    this.classes = new List<IClass>(value.Count);

                    this.AddClasses(value);
                }
            }
        }

        public void AddClass(IClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }

        public void RemoveClass(IClass schoolClass)
        {
            this.classes.Remove(schoolClass);
        }

        public void AddClasses(ICollection<IClass> schoolClasses)
        {
            foreach (var schoolClass in schoolClasses)
            {
                School.ValidateClass(schoolClass);

                this.classes.Add(schoolClass);
            }
        }

        public override string ToString()
        {
            return string.Format(School.ToStringFormat, this.Name);
        }

        private static void ValidateClass(IClass schoolClass)
        {
            if (schoolClass == null)
            {
                throw new NullReferenceException(School.ClassNullErrorMessage);
            }
        }
    }
}