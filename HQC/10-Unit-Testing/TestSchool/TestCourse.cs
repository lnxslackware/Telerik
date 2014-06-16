namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;
    using System.Collections.Generic;

    [TestClass]
    public class TestCourse
    {
        private School school = new School();
        private const int MaxStudentsInCourseCount = 30;
        private List<Student> testStudentList = new List<Student>();


        [TestInitialize()]
        private void InitializeStudentList()
        {
            for (int i = 0; i < MaxStudentsInCourseCount; i++)
            {
                testStudentList.Add(new Student("test", school));
            }
        }

        [TestMethod]
        public void CreatingACourse()
        {
            Student[] listOfStudents = new Student[] {
                new Student("pesho", school)
            };
            Course course = new Course(listOfStudents);
            Assert.IsInstanceOfType(course, typeof(Course));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingACourseWithNullSetOfStudents()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCourseWithAnEmptySetOfStudents()
        {
            Course course = new Course(new Student[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateCourseWithMoreThan30Students()
        {
            Student[] students = new Student[31];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("test student", school);
            }

            Course course = new Course(students);
        }

        [TestMethod]
        public void RemovingAStudentFromCourse()
        {
            for (int i = 0; i < MaxStudentsInCourseCount; i++)
            {
                testStudentList.Add(new Student("test", school));
            }

            Course course = new Course(testStudentList);
            Student studentToBeRemoved = testStudentList[3];
            Student removedStudent = course.RemoveStudent(studentToBeRemoved.UniqueNumber);
            Assert.AreEqual(studentToBeRemoved, removedStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingNonExistingStudentFromCourse()
        {
            for (int i = 0; i < MaxStudentsInCourseCount; i++)
            {
                testStudentList.Add(new Student("test", school));
            }

            Course course = new Course(testStudentList);
            Student student = course.RemoveStudent(123);
        }

        [TestMethod]
        public void RemovingAStudentFromCourseAndDecreasingStudentList()
        {
            for (int i = 0; i < MaxStudentsInCourseCount; i++)
            {
                testStudentList.Add(new Student("test", school));
            }

            Course course = new Course(testStudentList);
            Student studentToBeRemoved = testStudentList[3];
            Student removedStudent = course.RemoveStudent(studentToBeRemoved.UniqueNumber);
            Assert.AreEqual(testStudentList.Count - 1, new List<Student>(course.Students).Count);
        }

        [TestMethod]
        public void AddingStudentsToCourse()
        {
            Course course = new Course(new [] {new Student("pesho", school)});

            for (int i = 0; i < 10; i++)
            {
                course.AddStudent(new Student("gosho", school));
            }

            Assert.AreEqual(11, new List<Student>(course.Students).Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentToCourse()
        {
            Course course = new Course(new[] { new Student("pesho", school) });
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingStudentsToBeMoreThan30()
        {
            Course course = new Course(new[] { new Student("pesho", school) });

            for (int i = 0; i < MaxStudentsInCourseCount; i++)
            {
                course.AddStudent(new Student("gosho", school));
            }

            var count = new List<Student>(course.Students).Count;
            var a = 5;
        }
    }
}
