// Problem 3. Animal hierarchy
// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
// Kittens and tomcats are cats. All animals are described by age, name and sex.
// Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal
// using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AnimalHierarchy.Animals;
    using AnimalHierarchy.Interfaces;

    public class TestAnimalHierarchy
    {
        public static void Main()
        {
            var dogs = new List<Dog>
            {
                new Dog(4, "Emma", Gender.female),
                new Dog(3, "Scooby", Gender.male),
                new Dog(3, "Rusty", Gender.male)
            };

            var frogs = new List<Frog>
            {
                new Frog(8, "Kermit", Gender.male),
                new Frog(3, "Choker", Gender.male)
            };

            var cats = new List<Cat>
            {
                new Cat(3, "Garfield", Gender.male),
                new Cat(2, "Molly", Gender.female)
            };

            var kittens = new List<Kitten>
            {
                new Kitten(0.4, "Krissy"),
                new Kitten(0.5, "Arven"),
            };

            var tomcats = new List<Tomcat>
            {
                new Tomcat(0.6, "Tom" ),
                new Tomcat(0.2, "Charlie")
            };

            TestAnimalCollection(dogs);
            TestAnimalCollection(frogs);
            TestAnimalCollection(cats);
            TestAnimalCollection(kittens);
            TestAnimalCollection(tomcats);
        }

        private static void TestAnimalCollection(IEnumerable<Animal> animals)
        {
            string type = string.Format("{0}s", animals.First().GetType().Name);

            Console.WriteLine(new string('-', type.Length));
            Console.WriteLine(type);
            Console.WriteLine(new string('-', type.Length));
            PrintAnimalsCollection(animals);
            Console.WriteLine("\n{0} sound: {1}", type, animals.First().ProduceSound());
            Console.WriteLine("\nAverage age: {0:F1}\n", CalculateAnimalsAverageAge(animals));
        }

        private static void PrintAnimalsCollection(IEnumerable<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static double CalculateAnimalsAverageAge(IEnumerable<IAnimal> animals)
        {
            double averageAge = animals.Average(a => a.Age);

            return averageAge;
        }
    }
}