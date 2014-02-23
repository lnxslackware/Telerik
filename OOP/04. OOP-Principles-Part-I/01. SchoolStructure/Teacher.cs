using System;
using System.Collections.Generic;

namespace SchoolStructure
{
    public class Teacher : Person, ICommentable
    {
        public Teacher(string name, IEnumerable<Discipline> disciplineList, string comment = null)
            : base(name)
        {
            this.DisciplinesList = new List<Discipline>(disciplineList);
            this.Comment = comment;
        }

        public List<Discipline> DisciplinesList { get; private set; }

        public string Comment { get; set; }

    }
}
