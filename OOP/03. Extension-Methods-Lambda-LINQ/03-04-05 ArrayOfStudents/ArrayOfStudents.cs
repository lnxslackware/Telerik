using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStudents
{
    class ArrayOfStudents
    {
        static void Main()
        {
            Student[] students = 
            {
                new Student("Ivan", "Angelov", 23),
                new Student("Peter", "Hristov", 20),
                new Student("Angel", "Jordanov", 24),
                new Student("Angel", "Tzvetanov", 27),
                new Student("Zheko", "Miladinov", 23),
                new Student("Toni", "Petrov", 22),
                new Student("Boris", "Ivanov", 26)
            };

            //Task 3 - "Write a method that from a given array of students finds all
            //students whose first name is before its last name alphabetically. Use LINQ query operators."
            var selectedStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));

            //Task 4 - "Write a LINQ query that finds the first name and last name of all students with age between 18 and 24."
            selectedStudents =
                from student in students
                where (student.Age >= 18) && (student.Age <= 24)
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));

            //Task 5 - "Using the extension methods OrderBy() and ThenBy() with lambda expressions
            //sort the students by first name and last name in descending order. Rewrite the same with LINQ."

            //With lambda expressions
            selectedStudents =
                students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));

            //With LINQ
            selectedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
