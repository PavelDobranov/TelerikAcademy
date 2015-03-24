namespace AnimalHierarchy.Animals
{
    using AnimalHierarchy.Interfaces;

    public class Cat : Animal, IAnimal, ISound
    {
        private const string Sound = "miaow";

        public Cat(double age, string name, Gender gender)
            : this(age, name, gender, Cat.Sound)
        {
        }

        protected Cat(double age, string name, Gender gender, string sound)
            : base(age, name, gender, sound)
        {
        }
    }
}