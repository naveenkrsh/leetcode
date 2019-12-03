using System;
using System.Collections.Generic;
namespace LeetCode.Solutions.Stack.DailyTemperatures
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] T)
        {
            var total_temp = T.Length;
            var ans = new int[total_temp];
            var stack = new Stack<int>();

            for (int i = total_temp - 1; i >= 0; i--)
            {
                int temp = i;
                while (stack.Count != 0 && T[i] >=T[stack.Peek()])
                {
                    stack.Pop();
                }

                ans[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }
            return ans;
        }
    }
}
