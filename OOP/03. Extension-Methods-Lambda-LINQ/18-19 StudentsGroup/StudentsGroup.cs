using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroup
{
    class StudentsGroup
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan Angelov", "Project X"));
            students.Add(new Student("Peter Hristov", "QA"));
            students.Add(new Student("Angel Jordanov", "QA"));
            students.Add(new Student("Angel Tzvetanov", "Development"));
            students.Add(new Student("Zheko Miladinov", "QA"));
            students.Add(new Student("Toni Petrov", "Development"));

            //Task 18 - "Create a program that extracts all students grouped by GroupName
            //and then prints them to the console. Use LINQ."
            var groupStudents =
                from student in students
                group student by student.GroupName into gStudents
                select gStudents;

            foreach (var group in groupStudents)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine();
            }

            //Task 19 - "Rewrite the previous using extension methods."
            var grouped = students.GroupBy(student => student.GroupName);

            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
