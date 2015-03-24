namespace SchoolClasses
{
    using System.Collections.Generic;

    using SchoolClasses.Interfaces;

    public class Teacher : Human, ITeacher
    {
        private ICollection<IDiscipline> disciplines;

        public Teacher(string name, Gender gender)
            : base(name, gender)
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
            this.disciplines.Add(discipline);
        }
    }
}
