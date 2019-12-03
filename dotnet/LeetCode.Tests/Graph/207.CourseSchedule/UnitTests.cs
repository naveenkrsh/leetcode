using System;
using LeetCode.Solutions.Graph.CourseSchedule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LeetCode.Tests.Graph.CourseSchedule
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void TestInit()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void ShouldFinish()
        {
            /*
            Input: 2, [[1,0]] 
            Output: true
            Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0. So it is possible.
             */

            int[][] edgeList = new int[1][];
            edgeList[0] = new int[] { 1, 0 };

            var result = sol.CanFinish(2, edgeList);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotFinish()
        {
            /*
            Input: 2, [[1,0],[0,1]]
            Output: false
            Explanation: There are a total of 2 courses to take. 
             To take course 1 you should have finished course 0, and to take course 0 you should
             also have finished course 1. So it is impossible.
             */
            int[][] edgeList = new int[2][];

            edgeList[0] = new int[] { 1, 0 };
            edgeList[1] = new int[] { 0, 1 };

            var result = sol.CanFinish(2, edgeList);

            Assert.IsFalse(result);
        }
    }
}
