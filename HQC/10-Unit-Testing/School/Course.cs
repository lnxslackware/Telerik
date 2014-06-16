namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        //must be less than 30
        private List<Student> students;

        public IEnumerable<Student> Students
        {
            get
            {
                return new List<Student>(students);
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The set of students for the course cannot be null.");
                }

                List<Student> listOfStudents = new List<Student>(value);

                if (1 > listOfStudents.Count || listOfStudents.Count > 30)
                {
                    throw new ArgumentOutOfRangeException("The count of the students in the course must be between 0 and 30.");
                }

                this.students = listOfStudents;
            }
        }

        public Course(IEnumerable<Student> students)
        {
            this.Students = students;
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student you want to add is null.");
            }

            if (this.students.Count >= 30)
            {
                throw new InvalidOperationException("The course is full.(has 30 students).");
            }

            this.students.Add(student);
        }

        public Student RemoveStudent(int uniqueNumber)
        {
            var student = this.students.Find((x) => x.UniqueNumber == uniqueNumber);
            bool isRemoved = this.students.Remove(student);
            if (isRemoved == false)
            {
                throw new InvalidOperationException("Student not found in course.");
            }

            return student;
        }
    }
}
