namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int uniqueNumber;

        //must not be empty
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the student cannot be null.");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("The name of the student cannot be empty.");
                }

                this.name = value;
            }
        }

        public int UniqueNumber 
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                this.uniqueNumber = value;
            }
        }

        public Student(string name, School school)
        {
            if (school == null)
            {
                throw new ArgumentNullException("Student cannot be assigned to null.");
            }

            this.Name = name;
            this.UniqueNumber = school.NextStudentNumber;
        }
    }
}
