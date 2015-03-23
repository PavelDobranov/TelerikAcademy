// Problem 9. Student groups
// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
// Create a List<Student> with sample students. Select only the students that are from group number 2.
// Use LINQ query. Order the students by FirstName.

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class StudentGroupsQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            int groupNumber = 2;

            // Linq query
            var result = from student in students
                         where student.GroupNumber == groupNumber
                         select student;

            // Lambda
            //var result = students.Where(st => st.GroupNumber == groupNumber);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Students that are from group number {0}", groupNumber);
            Console.WriteLine("-------------------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}
