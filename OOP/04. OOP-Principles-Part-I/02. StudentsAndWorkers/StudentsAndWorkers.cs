using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class StudentsAndWorkers
    {
        static void Main()
        {
            //Initialize a list of 10 students
            List<Student> listOfStudents = new List<Student>()
            {
                new Student("Elena", "Kortezova", 4),
                new Student("Momchil", "Stalev", 6),
                new Student("Atanas", "Atanasov", 7),
                new Student("Nikolinka", "Dimitrova", 5),
                new Student("Trendafil", "Vanchev", 3),
                new Student("Georgi", "Tonchev", 6),
                new Student("Nina", "Ivanova", 7),
                new Student("Krasimir", "Kostadinov", 4),
                new Student("Nedialka", "Nikolova", 4),
                new Student("Vesa", "Georgieva", 7)
            };

            //Sort the students by grade in ascending order
            var sortedStudents = listOfStudents.OrderBy(student => student.Grade);

            Console.WriteLine("The sorted students:");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));

            //Initialize a list of 10 workers
            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker("Tzvetelina", "Zarkova", 420, 8),
                new Worker("Eva", "Jordanova", 432, 4),
                new Worker("Svetlana", "Ilieva", 220, 8),
                new Worker("Boris", "Valov", 260, 7),
                new Worker("Dimitar", "Atanasov", 180, 3),
                new Worker("Kiril", "Kirilov", 350, 8),
                new Worker("Ventzislav", "Stefanov", 287, 7),
                new Worker("Ivailo", "Iliev", 280, 10),
                new Worker("Mihail", "Mihalev", 245, 4),
                new Worker("Valentina", "Zhekova", 534, 8)
            };

            //Sort the workers by money earned by hour in descending order
            var sortedWorkers = listOfWorkers.OrderByDescending(worker => worker.MoneyPerHour());

            Console.WriteLine("The sorted students:");

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new string('-', 20));

            //Merge the lists
            List<Human> mixedList = new List<Human>();
            mixedList.AddRange(listOfStudents);
            mixedList.AddRange(listOfWorkers);

            //Sort the mixed list by first name and last name
            var sortedMixedList = mixedList.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            Console.WriteLine("The sorted mixed list:");

            foreach (var human in sortedMixedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}
