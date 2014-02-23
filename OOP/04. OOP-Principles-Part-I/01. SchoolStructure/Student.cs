using System;

namespace SchoolStructure
{
    public class Student : Person, ICommentable
    {
        public Student(string name, int uniqueClassNumber, string comment = null)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Comment = comment;
        }

        public int UniqueClassNumber { get; private set; }

        public string Comment { get; set; }
    }
}
