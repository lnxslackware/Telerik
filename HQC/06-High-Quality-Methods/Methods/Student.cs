using System;

namespace Methods
{
    class Student
    {
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.City = city;
        }
    }
}
