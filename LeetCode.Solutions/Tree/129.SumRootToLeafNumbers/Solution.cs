using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Tree.SumRootToLeafNumbers
{
    public class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
                return 0;
            
            var nums = new List<string>();
            SumNumbersUtil(root, "", nums);
            int result = 0;
            foreach (var n in nums)
            {
                result += Int32.Parse(n);
            }

            return result;
        }

        private void SumNumbersUtil(TreeNode root, string num,List<string> nums)
        {
            if (root.left == null && root.right == null)
            {
                num = num + root.val.ToString();
                nums.Add(num);
                return;
            }

            num = num + root.val.ToString();
            if (root.left != null)
                SumNumbersUtil(root.left, num, nums);
            if (root.right != null)
                SumNumbersUtil(root.right, num, nums);

        }
    }
}
