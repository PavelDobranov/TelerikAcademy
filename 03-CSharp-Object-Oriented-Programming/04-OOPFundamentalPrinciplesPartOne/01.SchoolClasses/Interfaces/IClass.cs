namespace SchoolClasses.Interfaces
{
    using System.Collections.Generic;

    public interface IClass
    {
        string Id { get; set; }
        
        ICollection<ITeacher> Teachers { get; }

        void AddTeacher(ITeacher teacher);

        void RemoveTeacher(ITeacher teacher);
    }
}