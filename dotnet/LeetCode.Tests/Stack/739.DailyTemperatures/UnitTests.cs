using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Stack.DailyTemperatures;

namespace LeetCode.Tests.Stack.DailyTemperatures
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void IntUnitTests()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void ShouldPass()
        {
            var T = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };

            var expected = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };

            var actual = sol.DailyTemperatures(T);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPassTestCase2()
        {
            var T = new int[] { 90, 63, 71, 59, 48, 48, 47, 77, 101, 71 };

            var expected = new int[] { 8, 1, 5, 4, 3, 2, 1, 1, 0, 0};

            var actual = sol.DailyTemperatures(T);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
