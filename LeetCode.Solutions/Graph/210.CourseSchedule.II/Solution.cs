using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Graph.CourseSchedule.II
{
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {

            var adlist = BuildAdjacencyList(numCourses, prerequisites);

            var visted = new bool[numCourses];
            var reOccur = new bool[numCourses];
            var stack = new Stack<int>();

            for (int i = 0; i < numCourses; i++)
            {
                if (FindOrderUtil(i, adlist, visted, reOccur, stack))
                {
                    return new int[0];
                }
            }

            var result = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                result[i] = stack.Pop();
            }

            return result;
        }

        private bool FindOrderUtil(int current, List<int>[] adlist, bool[] visted, bool[] reOccur, Stack<int> stack)
        {

            if (reOccur[current])
                return true;

            if (visted[current])
                return false;

            visted[current] = true;
            reOccur[current] = true;

            for (int i = 0; i < adlist[current].Count; i++)
            {
                var c = adlist[current][i];
                if (FindOrderUtil(c, adlist, visted, reOccur, stack))
                    return true;
            }

            reOccur[current] = false;
            stack.Push(current);

            return false;
        }

        private List<int>[] BuildAdjacencyList(int numCourses, int[][] prerequisites)
        {
            List<int>[] adjacencyList = new List<int>[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                adjacencyList[i] = new List<int>();
            }

            for (int i = 0; i < prerequisites.Length; i++)
            {
                var e = prerequisites[i];
                // u --> v
                var u = e[1];
                var v = e[0];

                adjacencyList[u].Add(v);
            }

            return adjacencyList;
        }
    }
}
