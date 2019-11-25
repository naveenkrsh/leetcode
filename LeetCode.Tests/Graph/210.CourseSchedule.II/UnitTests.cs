using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Graph.CourseSchedule.II;
namespace LeetCode.Tests.Graph.CourseSchedule.II
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void Init()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void ShouldReturnOrderTestCase1()
        {
            /*
            Input: 2, [[1,0]] 
            Output: [0,1]
            Explanation: There are a total of 2 courses to take. To take course 1 you should have finished   
             course 0. So the correct course order is [0,1] .
             */
            var noc = 2;
            var edgelist = new int[1][];
            edgelist[0] = new int[2] { 1, 0 };

            var result = sol.FindOrder(noc, edgelist);
            var expected = new int[] { 0, 1 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldReturnOrderTestCase2()
        {
            /*
            Input: 4, [[1,0],[2,0],[3,1],[3,2]]
            Output: [0,1,2,3] or [0,2,1,3]
            Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both     
             courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0. 
             So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3] .
             */
            var noc = 4;
            var edgelist = new int[4][];
            edgelist[0] = new int[2] { 1, 0 };
            edgelist[1] = new int[2] { 2, 0 };
            edgelist[2] = new int[2] { 3, 1 };
            edgelist[3] = new int[2] { 3, 2 };

            var result = sol.FindOrder(noc, edgelist);
            var expected = new int[] {0, 2, 1, 3 };

            CollectionAssert.AreEqual(expected, result);
        }

    }
}
