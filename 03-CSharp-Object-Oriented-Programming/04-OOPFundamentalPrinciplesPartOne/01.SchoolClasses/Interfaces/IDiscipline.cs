namespace SchoolClasses.Interfaces
{
    public interface IDiscipline
    {
        string Name { get; set; }

        int LecturesCount { get; set; }

        int ExercisesCount { get; set; }
    }
}