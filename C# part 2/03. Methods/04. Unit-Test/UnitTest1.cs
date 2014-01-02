using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int result = RepeatNumberCount.GetRepsCountInArray(arr, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AllElementsAreEqual()
        {
            int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int result = RepeatNumberCount.GetRepsCountInArray(arr, 1);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ExpectedCountIsOne()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = RepeatNumberCount.GetRepsCountInArray(arr, 10);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FirstTwoelementsAreRepeated()
        {
            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = RepeatNumberCount.GetRepsCountInArray(arr, 1);
            Assert.AreEqual(2, result);
        }
    }
}
