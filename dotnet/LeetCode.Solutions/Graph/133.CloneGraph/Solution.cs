using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Graph.CloneGraph
{
    public class Solution
    {
        public Node CloneGraph(Node node)
        {

            Dictionary<Node, Node> cloned = new Dictionary<Node, Node>();

            Queue<Node> bfsQ = new Queue<Node>();

            bfsQ.Enqueue(node);
            var newNode = new Node(node.val, new List<Node>());
            cloned.Add(node, newNode);

            while (bfsQ.Count != 0)
            {
                var current = bfsQ.Dequeue();


                var cloned_current = cloned[current];


                if (current.neighbors != null)
                {
                    foreach (var n in current.neighbors)
                    {
                        if (cloned.ContainsKey(n) == false)
                        {
                            bfsQ.Enqueue(n);
                            cloned.Add(n, new Node(n.val, new List<Node>()));
                        }

                        cloned_current.neighbors.Add(cloned[n]);
                    }
                }

            }

            return cloned[node];
        }

    }
}
