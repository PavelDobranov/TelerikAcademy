namespace AnimalHierarchy.Animals
{
    using AnimalHierarchy.Interfaces;

    public class Kitten : Cat, IAnimal, ISound
    {
        private const string Sound = "mrrr";

        public Kitten(double age, string name)
            : base(age, name, Gender.male, Kitten.Sound)
        {
        }
    }
}
