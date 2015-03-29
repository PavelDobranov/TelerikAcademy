namespace SchoolClasses.Interfaces
{
    using System.Collections.Generic;

    public interface IClass
    {
        string Id { get; set; }
        
        ICollection<IHuman> Humans { get; }

        void AddHuman(IHuman human);

        void RemoveHuman(IHuman human);

        void AddHumans(ICollection<IHuman> humans);
    }
}