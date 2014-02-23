using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolStructure
{
    public class SchoolClass : ICommentable
    {
        public SchoolClass(IEnumerable<Teacher> teacherList, IEnumerable<Student> studentsList, string uid, string comment = null)
        {
            this.TeacherList = new List<Teacher>(teacherList);
            this.StudentList = new List<Student>(studentsList);
            this.Uid = uid;
            this.Comment = comment;
        }

        public List<Teacher> TeacherList { get; private set; }
        
        public List<Student> StudentList { get; private set; }
        
        public string Uid { get; set; }

        public string Comment { get; set; }
    }
}
