// Problem 1. Student class
// Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
// mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, 
// universities and faculties.
// Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() 
// and operators == and !=.

// Problem 2. IClonable
// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
// into a new object of type Student.

// Problem 3. IComparable
// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
// and by social security number (as second criteria, in increasing order).

namespace StudentClass
{
    using System;

    public class TestStudent
    {
        public static void Main()
        {
            Console.BufferHeight = 100;

            try
            {
                var peshoStudent = new Student
                    (
                    "Petar",
                    "Petrov",
                    "Petrov",
                    123456,
                    "Vasil Aplrilov 20",
                    "0871234567",
                    "petar.petrov@gmail.com",
                    3,
                    University.TechnicalUniversityVarna,
                    Faculty.MachineTechnology,
                    Specialty.MechanicalEngineering
                    );

                var vankataStudent = new Student("Ivan",
                    "Ivanov",
                    "Ivanov",
                    654321,
                    "Oborishte 15",
                    "0881234567",
                    "ivan.ivanov@abv.bg",
                    5,
                    University.TechnicalUniversitySofia,
                    Faculty.ComputerSystemsAndControl,
                    Specialty.ComputerScience
                    );

                // test overrideed method ToString()
                Console.WriteLine("[ TEST - overrideed method ToString() ]");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(peshoStudent);
                Console.WriteLine(vankataStudent);

                // test overrideed method Equals()
                Console.WriteLine("\n[ TEST - overrideed method Equals() ]");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("peshoStudent.Equals(vankataStudent) : {0}", peshoStudent.Equals(vankataStudent));

                // test overrideed method GetHashCode()
                Console.WriteLine("\n[ TEST - overrideed method GetHashCode() ]");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("peshoStudent HashCode : {0} ", peshoStudent.GetHashCode());
                Console.WriteLine("vankataStudent HashCode : {0} ", vankataStudent.GetHashCode());

                // test overrideed operators == and !=
                Console.WriteLine("\n[ TEST - overrideed operators == and != ]");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("peshoStudent == vankataStudent : {0}", peshoStudent == vankataStudent);
                Console.WriteLine("peshoStudent != vankataStudent : {0}", peshoStudent != vankataStudent);

                // test Clone() method
                var clonedPesho = (Student)peshoStudent.Clone();

                Console.WriteLine("\n[ TEST - Clone() method ]");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(clonedPesho);
                Console.WriteLine("peshoStudent HashCode : {0} ", clonedPesho.GetHashCode());
                Console.WriteLine("peshoStudent == clonedPesho : {0}", peshoStudent == clonedPesho);
                Console.WriteLine("peshoStudent.Equals(clonedPesho) : {0}", peshoStudent.Equals(clonedPesho));

                // test CompareTo() method
                Console.WriteLine("\n[ TEST - CompareTo() method ]");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("peshoStudent.CompareTo(clonedPesho) : {0}", peshoStudent.CompareTo(clonedPesho));
                Console.WriteLine("peshoStudent.CompareTo(vankataStudent) : {0}", peshoStudent.CompareTo(vankataStudent));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}