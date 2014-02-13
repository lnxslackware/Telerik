using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudents
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1}{2}", this.FirstName, this.LastName, Environment.NewLine);
            result.AppendFormat("FN: {0} Tel: {1}{2}", this.FN, this.Tel, Environment.NewLine);
            result.AppendFormat("Email: {0} GroupNumber: {1}{2}", this.Email, this.GroupNumber, Environment.NewLine);
            result.Append("Marks: ");
            foreach (var mark in Marks)
            {
                result.AppendFormat("{0} ", mark);
            }
            result.Append(Environment.NewLine);

            return result.ToString();
        }
    }
}
