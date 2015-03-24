namespace AnimalHierarchy.Animals
{
    using System;

    using AnimalHierarchy.Interfaces;

    public abstract class Animal : IAnimal, ISound
    {
        private const string ValueLessOrEqualToZeroErrorMessage = "Cannot be less or equal to zero";
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string ToStringFormat = "Type: {0}, Age: {1}, Name: {2}";

        private double age;
        private string name;
        private string sound;

        public Animal(double age, string name, Gender gender, string sound)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.sound = sound;
        }

        public Gender Gender { get; set; }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age", Animal.ValueLessOrEqualToZeroErrorMessage);
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Animal.ValueNullOrEmptyErrorMessage, "Name");
                }

                this.name = value;
            }
        }

        public virtual string ProduceSound()
        {
            return this.sound;
        }

        public override string ToString()
        {
            return string.Format(Animal.ToStringFormat, this.GetType().Name, this.Age, this.Name);
        }
    }
}
