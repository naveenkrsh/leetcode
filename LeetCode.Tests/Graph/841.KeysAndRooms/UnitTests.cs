using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Graph.KeysAndRooms;
using System.Collections.Generic;

namespace LeetCode.Tests.Graph.KeysAndRooms
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void TesTInit()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void ShouldVisitAllRoom()
        {
            //arrange
            //Input: [[1],[2],[3],[]]
            IList<IList<int>> input = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 3 },
                new List<int>()
            };

            //act
            var result = sol.CanVisitAllRooms(input);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotVisitAllRoom()
        {
            //arrange
            //Input: [[1,3],[3,0,1],[2],[0]]
            IList<IList<int>> input = new List<IList<int>>
            {
                new List<int> { 1,3 },
                new List<int> { 3,0,1 },
                new List<int> { 2 },
                new List<int>{0}
            };

            //act
            var result = sol.CanVisitAllRooms(input);

            //assert
            Assert.IsFalse(result);
        }
    }
}
