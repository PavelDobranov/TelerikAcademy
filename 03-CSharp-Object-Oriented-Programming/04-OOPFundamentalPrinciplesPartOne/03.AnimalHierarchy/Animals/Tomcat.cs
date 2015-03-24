namespace AnimalHierarchy.Animals
{
    using AnimalHierarchy.Interfaces;

    public class Tomcat : Cat, IAnimal, ISound
    {
        private const string Sound = "hiss";

        public Tomcat(double age, string name)
            : base(age, name, Gender.male, Tomcat.Sound)
        {
        }
    }
}