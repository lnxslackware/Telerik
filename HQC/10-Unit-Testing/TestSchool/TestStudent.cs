namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class TestStudent
    {
        private School school = new School();

        [TestMethod]
        public void TestCreatingStudentWithAproperName()
        {
            Student student = new Student("ivan", school);
            Assert.AreEqual("ivan", student.Name);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentEmptyName()
        {
            Student student = new Student("", school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCreatingAStudentWithNullName()
        {
            Student student = new Student(null, school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCreatingAStudentWithNullSchool()
        {
            Student student = new Student("pesho", null);
        }

        [TestMethod]
        public void TestGeneratingDifferentStudentNumbers()
        {
            Student first = new Student("ivan", school);
            Student second = new Student("pesho", school);
            Assert.AreNotEqual(first.UniqueNumber, second.UniqueNumber);
        }
    }
}
