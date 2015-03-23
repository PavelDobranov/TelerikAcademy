// Problem 18. Grouped by GroupNumber
// Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
// Use LINQ.

namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class GroupedByGroupNumberQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            var result =
               from student in students
               group student by student.GroupNumber into grouped
               orderby grouped.Key
               select grouped;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Students grouped by GroupNumber");
            Console.WriteLine("-------------------------------");

            PrintGroupedStudents(students, result);
        }

        private static void PrintGroupedStudents(ICollection<Student> students, IOrderedEnumerable<IGrouping<int, Student>> result)
        {
            foreach (var groupNumber in result)
            {
                Console.WriteLine("Group: {0}", groupNumber.Key);

                foreach (var student in students)
                {
                    if (student.GroupNumber == groupNumber.Key)
                    {
                        Console.WriteLine(" - {0} {1}", student.FirstName, student.LastName);
                    }
                }
            }
        }
    }
}