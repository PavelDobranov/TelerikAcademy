// Problem 19. Grouped by GroupName extensions
// Rewrite the previous using extension methods.

namespace GroupedByGroupNameExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class GroupedByGroupNameExtensionsQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            var result = students
                            .GroupBy(st => st.GroupNumber)
                            .OrderBy(st => st.Key);

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