namespace AnimalHierarchy.Animals
{
    using AnimalHierarchy.Interfaces;

    public class Dog : Animal, IAnimal, ISound
    {
        private const string Sound = "bow-wow";

        public Dog(double age, string name, Gender gender)
            : base(age, name, gender, Dog.Sound)
        {
        }
    }
}
