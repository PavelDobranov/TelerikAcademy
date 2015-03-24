namespace SchoolClasses.Interfaces
{
    public interface IStudent
    {
        string Name { get; set; }

        Gender Gender { get; set; }

        int ClassNumber { get; set; }
    }
}
