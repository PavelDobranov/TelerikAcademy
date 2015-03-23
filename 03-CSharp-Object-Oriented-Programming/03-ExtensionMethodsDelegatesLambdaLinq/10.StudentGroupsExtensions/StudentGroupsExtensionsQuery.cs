// Problem 10. Student groups extensions
// Implement the previous using the same query expressed with extension methods.

namespace StudentGroupsExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class StudentGroupsExtensionsQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            int groupNumber = 2;

            var result = students.Where(st => st.GroupNumber == groupNumber);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Students that are from group number {0}", groupNumber);
            Console.WriteLine("-------------------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}