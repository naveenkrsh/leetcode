using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Graph.CourseSchedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<int>[] adjacencyList = BuildAdjacencyList(numCourses, prerequisites);

            return !IsCycle(numCourses, adjacencyList);
        }

        private bool IsCycle(int numCourses, List<int>[] adjacencyList)
        {
            bool[] visted = new bool[numCourses];
            bool[] reOccurInCallStack = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                if (IsCycleUtil(i, visted, reOccurInCallStack, adjacencyList))
                    return true;
            }
            return false;
        }

        private bool IsCycleUtil(int current, bool[] visted, bool[] reOccurInCallStack, List<int>[] adjacencyList)
        {
            if (reOccurInCallStack[current])
                return true;

            if (visted[current])
                return false;

            visted[current] = true;
            reOccurInCallStack[current] = true;

            for (int i = 0; i < adjacencyList[current].Count; i++)
            {
                var v = adjacencyList[current][i];
                if (IsCycleUtil(v, visted, reOccurInCallStack, adjacencyList))
                    return true;
            }

            reOccurInCallStack[current] = false;
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
                // u-->v
                int u = e[1];
                int v = e[0];

                adjacencyList[u].Add(v);
            }
            return adjacencyList;
        }

    }
}
