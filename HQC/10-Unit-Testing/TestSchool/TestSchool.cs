namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void TestIncreasingStudentNumbersWhenTheGetterIsCalled()
        {
            School school = new School();
            int firstStudentNumber = school.NextStudentNumber;
            int secondStudentNumber = school.NextStudentNumber;
            Assert.AreEqual(firstStudentNumber + 1, secondStudentNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMoreThanMaxNumberOfStudentsInSchool()
        {
            int maxCountOfStudents = 99999 - 10000;
            School school = new School();
            int currentStudentNumber = school.NextStudentNumber;

            for (int i = 0; i < maxCountOfStudents + 1; i++)
            {
                currentStudentNumber = school.NextStudentNumber;
            }
        }
    }
}
