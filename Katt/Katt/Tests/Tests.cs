using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using KittyTask1;

namespace Tests
{
    public class Tests
    {
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 0, -1 }, -1)]
        [TestCase(new int[] { 0 }, 0)]
        public void Task1(int[] array, int expectedResult)
        {
            var result = KittyTask.Smallest(array);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(new int[] {  }, 1, false)]
        [TestCase(new int[] { 0 }, 0, true)]
        [TestCase(new int[] { 0 }, 1, false)]
        public void Task2(int[] array, int value, bool expectedResult)
        {
            var result = KittyTask2.Contains(array, value);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(new int[] {  }, 0)]
        [TestCase(new int[] { 0, -1 }, -1)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 6)]
        public void Task3(int[] array, int expectedResult)
        {
            var result = KittyTask3.Sum(array);

            Assert.AreEqual(expectedResult, result);
        }
    }
}