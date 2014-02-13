/*
 * Create a class student with properties FirstName, LastName, FN, Tel, Email,
 * Marks (a List<int>), GroupNumber. Create a List<Student> with sample students.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudents
{
    class SortStudents
    {
        private static void PrintCollection(dynamic collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            //adding some students in a list
            List<Student> students = new List<Student>();

            students.Add(new Student("Ivan", "Angelov", 43430653, "088333352", "iangelov@abv.bg", new int[] { 4, 2, 4, 3, 3, 5 }.ToList(), 4));
            students.Add(new Student("Peter", "Hristov", 65466532, "02532563", "p.hristov@gmail.com", new int[] { 6, 6, 5, 6, 3, 4 }.ToList(), 2));
            students.Add(new Student("Angel", "Jordanov", 43430632, "064824535", "tozi@yahoo.com", new int[] { 3, 4, 6, 2, 3, 3 }.ToList(), 1));
            students.Add(new Student("Angel", "Tzvetanov", 2553351, "05325636", "tzvetanovA@abv.bg", new int[] { 5, 3, 2, 4, 4, 2 }.ToList(), 2));
            students.Add(new Student("Zheko", "Miladinov", 53466566, "02324632", "zheko@gbg.bg", new int[] { 6, 6, 6, 6, 4, 5 }.ToList(), 5));
            students.Add(new Student("Toni", "Petrov", 5325353, "0878532532", "petrov@gmail.com", new int[] { 5, 2, 2, 6, 3, 4 }.ToList(), 1));
            students.Add(new Student("Boris", "Ivanov", 76760643, "0898532535", "biivanov@mail.bg", new int[] { 3, 5, 3, 3, 5, 4 }.ToList(), 3));

            //Task 9 - "Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName."
            var selectedStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            PrintCollection(selectedStudents);

            Console.WriteLine(new string('-', 20));

            //Task 10 - "Implement the previous using the same query expressed with extension methods."
            selectedStudents = students.Where(student => (student.GroupNumber == 2)).OrderBy(student => student.FirstName);

            PrintCollection(selectedStudents);

            Console.WriteLine(new string('-', 20));

            //Task 11 - "Extract all students that have email in abv.bg. Use string methods and LINQ."
            var anotherStudentsSelection =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            PrintCollection(anotherStudentsSelection);

            Console.WriteLine(new string('-', 20));

            //Task 12 - "Extract all students with phones in Sofia. Use LINQ."
            anotherStudentsSelection =
                from student in students
                where student.Tel.StartsWith("02")
                select student;

            PrintCollection(anotherStudentsSelection);

            Console.WriteLine(new string('-', 20));

            //Task 13 - "Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks. Use LINQ."
            var studentsSelectedByMarks =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = string.Join(" ", student.Marks)
                };

            PrintCollection(studentsSelectedByMarks);

            Console.WriteLine(new string('-', 20));

            //Task 14 - "Write down a similar program that extracts the students with exactly
            //two marks "2". Use extension methods."
            studentsSelectedByMarks =
                students.Where(student => (student.Marks.FindAll(x => x == 2)).Count == 2)
                .Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = string.Join(" ", student.Marks)
                }
                );

            PrintCollection(studentsSelectedByMarks);

            Console.WriteLine(new string('-', 20));

            //Task 15 - "Extract all Marks of the students that enrolled in 2006.
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN)."
            var studentsSelectedByYear =
                students.Where(student => (student.FN.ToString()[4] == '0') && (student.FN.ToString()[5] == '6'))
                .Select(student => new
                {
                    Marks = string.Join(" ", student.Marks)
                }
                );

            PrintCollection(studentsSelectedByYear);

            Console.WriteLine(new string('-', 20));
        }
    }
}
