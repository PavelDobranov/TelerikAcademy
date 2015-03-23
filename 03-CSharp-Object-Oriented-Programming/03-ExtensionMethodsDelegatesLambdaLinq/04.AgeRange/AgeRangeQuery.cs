// Problem 4. Age range
// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class AgeRangeQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            int minAge = 18;
            int maxAge = 24;

            // Linq query
            var result = from student in students
                         where student.Age >= minAge && student.Age <= maxAge
                         select student;

            // Lambda
            //var result = students.Where(st => st.Age >= minAge && st.Age <= maxAge);

            Console.WriteLine("-------------------");
            Console.WriteLine("Age range : {0} - {1}", minAge, maxAge);
            Console.WriteLine("-------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}