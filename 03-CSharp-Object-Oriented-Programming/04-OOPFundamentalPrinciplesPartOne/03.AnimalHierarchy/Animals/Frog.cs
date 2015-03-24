namespace AnimalHierarchy.Animals
{
    using AnimalHierarchy.Interfaces;

    public class Frog : Animal, IAnimal, ISound
    {
        private const string Sound = "croak-croak";

        public Frog(double age, string name, Gender gender)
            : base(age, name, gender, Frog.Sound)
        {
        }
    }
}
