using System;
using System.Linq;

namespace SchoolStructure
{
    public class Discipline : ICommentable
    {
        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Comment = comment;
        }

        public string Name { get; private set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }
    }
}
