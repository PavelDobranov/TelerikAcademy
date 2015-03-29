namespace SchoolClasses.Interfaces
{
    using System.Collections.Generic;

    public interface ITeacher : IHuman
    {
        ICollection<IDiscipline> Disciplines { get; }

        void AddDiscipline(IDiscipline discipline);

        void RemoveDiscipline(IDiscipline discipline);

        void AddDisciplines(ICollection<IDiscipline> disciplines);
    }
}