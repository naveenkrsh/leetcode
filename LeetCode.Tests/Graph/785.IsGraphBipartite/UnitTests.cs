using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Graph.IsGraphBipartite;

namespace LeetCode.Tests.Graph.IsGraphBipartite
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ShouldBeBipartiteGraphForConnectedGraphUsingBFS()
        {
            //Input: [[1, 3], [0,2], [1,3], [0,2]]

            int[][] graph = new int[4][];
            graph[0] = new int[] { 1, 3 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 1, 3 };
            graph[3] = new int[] { 0, 2 };

            Solution sol = new Solution();
            var result = sol.IsBipartiteBFS(graph);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldBeBipartiteGraphForDisConnectedGraphUsingBFS()
        {
            //Input: [[1, 3], [0,2], [1,3], [0,2]]

            int[][] graph = new int[8][];
            graph[0] = new int[] { 1, 3 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 1, 3 };
            graph[3] = new int[] { 0, 2 };

            graph[4] = new int[] { 5, 7 };
            graph[5] = new int[] { 4, 6 };
            graph[6] = new int[] { 5, 7 };
            graph[7] = new int[] { 4, 6 };

            Solution sol = new Solution();
            var result = sol.IsBipartiteBFS(graph);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotBeBipartiteGraphForConnectedGraphUsingBFS()
        {
            //Input: [[1,2,3], [0,2], [0,1,3], [0,2]]

            int[][] graph = new int[4][];
            graph[0] = new int[] { 1, 2, 3 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 0, 1, 3 };
            graph[3] = new int[] { 0, 2 };

            Solution sol = new Solution();
            var result = sol.IsBipartiteBFS(graph);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotBeBipartiteGraphForDisConnectedGraphUsingBFS()
        {
            //Input: [[1,2,3], [0,2], [0,1,3], [0,2]]

            int[][] graph = new int[8][];
            graph[0] = new int[] { 1, 2, 3 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 0, 1, 3 };
            graph[3] = new int[] { 0, 2 };

            graph[4] = new int[] { 5, 6, 7 };
            graph[5] = new int[] { 4, 6 };
            graph[6] = new int[] { 4, 5, 7 };
            graph[7] = new int[] { 4, 6 };

            Solution sol = new Solution();
            var result = sol.IsBipartiteBFS(graph);

            Assert.IsFalse(result);
        }
    }
}
