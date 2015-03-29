namespace SchoolClasses.Interfaces
{
    using System.Collections.Generic;

    public interface ISchool
    {
        string Name { get; set; }

        ICollection<IClass> Classes { get; }

        void AddClass(IClass schoolClass);

        void RemoveClass(IClass schoolClass);

        void AddClasses(ICollection<IClass> schoolClasses);
    }
}