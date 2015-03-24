// Problem 2. Students and workers
// Define abstract class Human with first name and last name. 
// Define new class Student which is derived from Human and has new field – grade. 
// Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
// and method MoneyPerHour() that returns money earned by hour by the worker.
// Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentsAndWorkers.Humans;
    using StudentsAndWorkers.Interfaces;

    public static class TestStudentsAndWorkers
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Peter", "Petrov", 4),
                new Student("Martin", "Ivanov", 3),
                new Student("Maria", "Dimitrova", 1),
                new Student("Anna", "Mihailova", 4),
                new Student("Georgi", "Penchev", 3),
                new Student("Aleksander", "Ivanov", 1),
                new Student("Stefan", "Aleksandrov", 2),
                new Student("Irina", "Koleva", 2),
                new Student("Stefka", "Dimitrova", 3),
                new Student("Mihail", "Stykov", 5)
            };

            var sortedStudents = students.OrderBy(s => s.Grade);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sorted students by grade in ascending order");
            Console.WriteLine("-------------------------------------------");
            PrintHumansCollection(sortedStudents);

            var workers = new List<Worker>
            {
                new Worker("Petar", "Shopov", 89, 15),
                new Worker("Milen", "Stoev", 233, 40),
                new Worker("Irina", "Yordanova", 326, 40),
                new Worker("Tihomir", "Zlatev", 108, 25),
                new Worker("Biser", "Stoyanov", 86, 20),
                new Worker("Kamen", "Ivanov", 212, 35),
                new Worker("Mila", "Petrova", 368, 40),
                new Worker("Simeon", "Stefanov", 185, 15),
                new Worker("Vladimir", "Koolev", 164, 26),
                new Worker("Veneta", "Petrova", 226, 30)
            };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Sorted workers by money per hour in descending order");
            Console.WriteLine("----------------------------------------------------");
            PrintHumansCollection(sortedWorkers);

            var mergedHumans = students.Concat<Human>(workers)
                                       .OrderBy(h => h.FirstName)
                                       .ThenBy(h => h.LastName);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Merged and sorted humans by first name and last name");
            Console.WriteLine("----------------------------------------------------");
            PrintHumansCollection(mergedHumans);

        }

        private static void PrintHumansCollection(IEnumerable<IHuman> humans)
        {
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}