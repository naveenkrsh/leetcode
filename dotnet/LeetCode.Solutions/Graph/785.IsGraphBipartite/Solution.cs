using System;
using System.Collections.Generic;
namespace LeetCode.Solutions.Graph.IsGraphBipartite
{
    public class Solution
    {
        public bool IsBipartite(int[][] graph)
        {
            return IsBipartiteBFS(graph);
        }


        public bool IsBipartiteBFS(int[][] graph)
        {
            int total_vertes = graph.Length;
            
            int[] color = new int[total_vertes];
            InitColor(total_vertes, color);


            //for disconnected graph

            for (int i = 0; i < total_vertes; i++)
            {
                if (color[i] == -1)
                {
                    if (IsBipartiteBFSUtil(graph, color, i) == false)
                        return false;
                }
            }
            return true;
        }

        private static bool IsBipartiteBFSUtil(int[][] graph, int[] color,int start)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(start);
            color[start] = 0;

            while (q.Count != 0)
            {
                int current = q.Dequeue();
                int current_color = color[current];

                for (int i = 0; i < graph[current].Length; i++)
                {
                    int ad = graph[current][i];

                    if (color[ad] == -1)
                    {
                        color[ad] = 1 - current_color;
                        q.Enqueue(ad);
                    }
                    else if (color[ad] == current_color)
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        private static void InitColor(int total_vertes, int[] color)
        {
            for (int i = 0; i < total_vertes; i++)
            {
                color[i] = -1;
            }
        }

        //TODO: using DFS
        public bool DFS(int[][] graph)
        {
            return true;
        }
    }
}
