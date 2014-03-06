using System;

namespace ClassStudent
{
    class ClassStudentTest
    {
        static void Main()
        {
            Student student = new Student("Peter", "Ivanov", "Petkanov", 353253255, 
                "Pleven, Druzhba 425", "0888888888", "safas@gfsa.fsa", 3, Specialties.QuantumPhysics,
                Universities.TelerikAcademy, Faculties.Physics);

            Console.WriteLine(student);
        }
    }
}
