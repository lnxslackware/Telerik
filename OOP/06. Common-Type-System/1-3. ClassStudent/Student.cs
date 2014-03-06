namespace ClassStudent
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student()
        {

        }

        public Student(string firstName, string middleName, string lastName, int ssn, string permAddress,
            string mobilePhone, string email, int course, Specialties specialty, Universities university,
            Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        private string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Student name: {0} {1} {2}\r\n", this.FirstName, this.MiddleName, this.LastName);
            result.AppendFormat("SSN: {0} Mobile Phone: {1} E-mail: {2}\r\n", this.Ssn, this.MobilePhone, this.Email);
            result.AppendFormat("Course: {0} University {1} Faculty {2} Specialty {3}\r\n", this.Course, this.University, this.Faculty, this.Specialty);

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Student))
            {
                return false;
            }

            Student student = obj as Student;

            if (this.Ssn == student.Ssn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (this.Ssn - this.Course) / 2;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1.Equals(student2));
        }

        public object Clone()
        {
            Student student = new Student();
            student.FirstName = this.FirstName.Clone().ToString();
            student.MiddleName = this.MiddleName.Clone().ToString();
            student.LastName = this.LastName.Clone().ToString();
            student.Ssn = this.Ssn;
            student.PermanentAddress = this.PermanentAddress.Clone().ToString();
            student.MobilePhone = this.MobilePhone.Clone().ToString();
            student.Email = this.Email.Clone().ToString();
            student.University = this.University;
            student.Faculty = this.Faculty;

            return student;
        }

        public int CompareTo(Student other)
        {
            int resultOfComparison = this.FullName.CompareTo(other.FullName);
            
            if (resultOfComparison == 0)
            {
                resultOfComparison = this.Ssn.CompareTo(other.Ssn);
            }

            return resultOfComparison;
        }
    }
}