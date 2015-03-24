namespace SchoolClasses.Interfaces
{
    using System.Collections.Generic;

    public interface ITeacher
    {
        string Name { get; set; }

        Gender Gender { get; set; }

        ICollection<IDiscipline> Disciplines { get; }

        void AddDiscipline(IDiscipline discipline);
    }
}