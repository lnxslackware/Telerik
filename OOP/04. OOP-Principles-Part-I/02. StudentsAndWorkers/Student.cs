using System;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("The grade must be greather than 0 and less than 14");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - Grade: {1}", base.ToString(), this.grade);
        }
    }
}
