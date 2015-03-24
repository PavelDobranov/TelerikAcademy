﻿namespace SchoolClasses.Humans
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SchoolClasses.Interfaces;

    public class Teacher : Human, IHuman, ITeacher, ICommentable
    {
        private const string DisciplineNullErrorMessage = "Discipline cannot be null";

        private ICollection<IDiscipline> disciplines;

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.disciplines = new List<IDiscipline>();
        }

        public ICollection<IDiscipline> Disciplines
        {
            get
            {
                return new List<IDiscipline>(this.disciplines);
            }
        }

        public void AddDiscipline(IDiscipline discipline)
        {
            Teacher.ValidateDiscipline(discipline);

            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(IDiscipline discipline)
        {
            Teacher.ValidateDiscipline(discipline);

            this.disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.AppendLine("Disciplines: ");

            foreach (var discipline in this.disciplines)
            {
                result.AppendLine(discipline.ToString());
            }

            return result.ToString().Trim();
        }

        private static void ValidateDiscipline(IDiscipline discipline)
        {
            if (discipline == null)
            {
                throw new NullReferenceException(Teacher.DisciplineNullErrorMessage);
            }
        }
    }
}