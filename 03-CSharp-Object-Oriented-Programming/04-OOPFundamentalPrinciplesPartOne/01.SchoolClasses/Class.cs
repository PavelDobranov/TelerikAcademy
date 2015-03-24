namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SchoolClasses.Interfaces;

    public class Class : IClass, ICommentable
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string TeacherNullErrorMessage = "Teacher cannot be null";

        private string id;
        private ICollection<ITeacher> teachers;

        public Class(string id)
        {
            this.Id = id;
            this.teachers = new List<ITeacher>();
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new System.ArgumentException(Class.ValueNullOrEmptyErrorMessage, "Id");
                }

                this.id = value;
            }
        }

        public System.Collections.Generic.ICollection<ITeacher> Teachers
        {
            get
            {
                return new List<ITeacher>(this.teachers);
            }
        }

        public string Comment { get; set; }

        public void AddTeacher(ITeacher teacher)
        {
            Class.ValidateTeacher(teacher);

            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(ITeacher teacher)
        {
            Class.ValidateTeacher(teacher);

            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Class: " + this.Id);
            result.AppendLine("Teachers: ");

            foreach (var teacher in this.teachers)
            {
                result.AppendLine(teacher.FirstName + " " + teacher.LastName);
            }

            return result.ToString().Trim();
        }

        private static void ValidateTeacher(ITeacher teacher)
        {
            if (teacher == null)
            {
                throw new NullReferenceException(Class.TeacherNullErrorMessage);
            }
        }
    }
}