using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetCode.Solutions.Graph.CloneGraph;
namespace LeetCode.Tests.Graph.CloneGraph
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void ShouldCloneTheGraph()
        {

            Node n1 = new Node(1, new List<Node>());
            Node n2 = new Node(2, new List<Node>());
            Node n3 = new Node(3, new List<Node>());
            Node n4 = new Node(4, new List<Node>());

            n1.neighbors.Add(n2);
            n1.neighbors.Add(n4);

            n2.neighbors.Add(n1);
            n2.neighbors.Add(n3);

            n3.neighbors.Add(n2);
            n3.neighbors.Add(n4);

            n4.neighbors.Add(n1);
            n4.neighbors.Add(n3);


            var original = BFS(n1);

            Solution sol = new Solution();
            var clonedGraph = sol.CloneGraph(n1);

            var cloned = BFS(clonedGraph);


            for (int i = 0; i < original.Count; i++)
            {
                Assert.AreEqual(original[i].Key, cloned[i].Key);
                Assert.AreNotEqual(original[i].Value, cloned[i].Value);
            }
        }

        private List<KeyValuePair<int, int>> BFS(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            HashSet<Node> visted = new HashSet<Node>();

            q.Enqueue(node);
            visted.Add(node);

            List<KeyValuePair<int, int>> result = new List<KeyValuePair<int, int>>();

            while (q.Count != 0)
            {
                var current = q.Dequeue();
                result.Add(new KeyValuePair<int, int>(current.val, current.GetHashCode()));

                if (current.neighbors != null)
                {
                    foreach (var n in current.neighbors)
                    {
                        if (visted.Contains(n) == false)
                        {
                            visted.Add(n);
                            q.Enqueue(n);
                        }
                    }
                }
            }
            return result;
        }
    }
}
