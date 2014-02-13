namespace ArrayOfStudents
{
    using System.Text;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} age: {2}", this.FirstName, this.LastName, this.Age);
            
            return result.ToString();
        }
    }
}
