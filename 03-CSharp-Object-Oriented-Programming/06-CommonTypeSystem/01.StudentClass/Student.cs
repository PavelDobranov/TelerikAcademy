namespace StudentClass
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    using StudentClass.Attributes;

    public class Student : ICloneable, IComparable<Student>
    {
        private const int CourseMinValue = 1;
        private const int CourseMaxValue = 5;

        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string mobile;
        private string email;
        private int course;

        // private constructor 
        // for Clone() method
        private Student()
        {
        }

        public Student(string firstName, string middleName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
        }

        public Student(string firstName, string middleName, string lastName, int ssn, string adress, string mobile, string email, int course, University university, Faculty faculty, Specialty specialty)
            : this(firstName, middleName, lastName, ssn)
        {
            this.Adress = adress;
            this.Mobile = mobile;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        [ToString("First Name")]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Regex rgx = new Regex(@"^[A-Z][a-z]{2,}$");
                string errMsg = "First name must contains atleast three letters, must start with a UPPERCASE letter and can only contain letters";

                ValidateProprtyValue(value, rgx, errMsg);

                this.firstName = value;
            }
        }

        [ToString("Middle Name")]
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                Regex rgx = new Regex(@"^[A-Z][a-z]{2,}$");
                string errMsg = "Middle name must contains atleast three letters, must start with a UPPERCASE letter and can only contain letters";

                ValidateProprtyValue(value, rgx, errMsg);

                this.middleName = value;
            }
        }

        [ToString("Last Name")]
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Regex rgx = new Regex(@"^[A-Z][a-z]{2,}$");
                string errMsg = "Last name must contains atleast three letters, must start with a UPPERCASE letter and can only contain letters";

                ValidateProprtyValue(value, rgx, errMsg);

                this.lastName = value;
            }
        }

        [ToString("SSN")]
        public int Ssn
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                Regex rgx = new Regex(@"^[0-9]{6}$");
                string errMsg = "Social security number must contain exactly six integer numbes";

                ValidateProprtyValue(value.ToString(), rgx, errMsg);

                this.ssn = value;
            }
        }

        [ToString("Mobile")]
        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                Regex rgx = new Regex(@"^(087|088|089)[0-9]{7}$");
                string errMsg = "Invalid mobile number! (e.g. 087xxxxxxx / 088xxxxxxx / 089xxxxxxx)";

                ValidateProprtyValue(value, rgx, errMsg);

                this.mobile = value;
            }
        }

        [ToString("E-mail")]
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                Regex rgx = new Regex(@"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,4})$");
                string errMsg = "Invalid e-mail address!";

                ValidateProprtyValue(value, rgx, errMsg);

                this.email = value;
            }
        }

        [ToString("Course")]
        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value < Student.CourseMinValue || value > Student.CourseMaxValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Course value must be in range : {0} to {1}", Student.CourseMinValue, Student.CourseMaxValue));
                }

                this.course = value;
            }
        }

        [ToString("Adress")]
        public string Adress { get; set; }

        [ToString("University")]
        public University University { get; set; }

        [ToString("Faculty")]
        public Faculty Faculty { get; set; }

        [ToString("Specialty")]
        public Specialty Specialty { get; set; }

        public override int GetHashCode()
        {
            int bitShift = 17;

            int firstNameHash = (this.FirstName == null ? 0 : this.FirstName.GetHashCode()) << bitShift;
            int middleNameHash = (this.MiddleName == null ? 0 : this.MiddleName.GetHashCode()) >> bitShift;
            int lastNameHash = (this.LastName == null ? 0 : this.LastName.GetHashCode()) << bitShift;
            int ssnHash = this.Ssn.GetHashCode() >> bitShift;
            int adressHash = (this.Adress == null ? 0 : this.Adress.GetHashCode()) << bitShift;
            int mobileHash = (this.Mobile == null ? 0 : this.Mobile.GetHashCode()) >> bitShift;
            int emailHash = (this.Email == null ? 0 : this.Email.GetHashCode()) << bitShift;
            int courseHash = this.Course.GetHashCode() >> bitShift;
            int universityHash = this.University.GetHashCode() << bitShift;
            int facultyHash = this.Faculty.GetHashCode() >> bitShift;
            int specialtyHash = this.Specialty.GetHashCode() << bitShift;

            return firstNameHash ^ middleNameHash ^ lastNameHash ^ ssnHash ^ adressHash ^ mobileHash ^
                emailHash ^ courseHash ^ universityHash ^ facultyHash ^ specialtyHash;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null)
            {
                throw new ArgumentException("Passed parameter is not student");
            }

            if (this.GetHashCode() == student.GetHashCode())
            {
                return true;
            }

            return false;
        }

        public object Clone()
        {
            var student = new Student();

            student.FirstName = (string)this.FirstName.Clone();
            student.MiddleName = (string)this.MiddleName.Clone();
            student.LastName = (string)this.LastName.Clone();
            student.Ssn = this.Ssn;
            student.course = this.Course;
            student.Mobile = (string)this.Mobile.Clone();
            student.Email = (string)this.Email.Clone();
            student.Adress = (string)this.Adress.Clone();
            student.University = this.University;
            student.Faculty = this.Faculty;
            student.Specialty = this.Specialty;

            return student;
        }

        public int CompareTo(Student other)
        {
            if (this.firstName.CompareTo(other.firstName) != 0)
            {
                return this.firstName.CompareTo(other.firstName);
            }

            if (this.middleName.CompareTo(other.middleName) != 0)
            {
                return this.middleName.CompareTo(other.middleName);
            }

            if (this.lastName.CompareTo(other.lastName) != 0)
            {
                return this.lastName.CompareTo(other.lastName);
            }

            if (this.Ssn != other.Ssn)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }

            return 0;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override string ToString()
        {
            var studentInfo = new StringBuilder();

            var studentProperties = this.GetType().GetProperties();

            foreach (var property in studentProperties)
            {
                var attributes = property.GetCustomAttributes(typeof(ToStringAttribute), false);

                if (attributes.Length == 1)
                {
                    string propertyName = attributes[0].ToString();
                    string propertyValue = PorpertyValueToString(property.GetValue(this));

                    studentInfo.AppendLine(string.Format("{0} : {1}", propertyName, propertyValue));
                }
            }

            return studentInfo.ToString();
        }

        private void ValidateProprtyValue(string value, Regex rgx, string errMsg)
        {
            if (rgx.IsMatch(value) == false)
            {
                throw new ArgumentException(errMsg);
            }
        }

        private string PorpertyValueToString<T>(T value)
        {
            if (value.GetType().IsEnum)
            {
                var result = new StringBuilder();

                string valueToString = value.ToString();

                for (int i = 0; i < valueToString.Length; i++)
                {
                    if (i != 0 && char.IsUpper(valueToString[i]))
                    {
                        result.Append(' ');
                    }

                    result.Append(valueToString[i]);
                }

                return result.ToString();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}