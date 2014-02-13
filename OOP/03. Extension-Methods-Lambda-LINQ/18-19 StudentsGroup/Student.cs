using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroup
{
    public struct Student
    {
        public string Name { get; set; }
        public string GroupName { get; set; }

        public Student(string name, string groupName) : this()
        {
            this.Name = name;
            this.GroupName = groupName;
        }
    }
}
