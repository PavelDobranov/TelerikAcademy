// Problem 16.* Groups
// Create a class Group with properties GroupNumber and DepartmentName.
// Introduce a property GroupNumber in the Student class.
// Extract all students from "Mathematics" department.
// Use the Join operator.

namespace Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class MathematicsDepartmentQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();
            var groups = GroupsData.GetGroups();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            Console.WriteLine("----------");
            Console.WriteLine("All gropus");
            Console.WriteLine("----------");

            groups.ForEach(Console.WriteLine);

            string department = "Mathematics";

            var result = from student in students
                         join gr in groups on student.GroupNumber equals gr.GroupNumber
                         where gr.DepartmentName == department
                         select student;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Students from \"Mathematics\" department");
            Console.WriteLine("----------------------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}