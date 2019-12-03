using System;
using LeetCode.Solutions.Tree;
namespace LeetCode.Solutions.Tree.MergeTwoBinaryTrees
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            return MergeTreesUtil(t1, t2);
          
        }

        public TreeNode MergeTreesUtil(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;

            if (t2 == null)
                return t1;

            t1.val += t2.val;

            t1.left = MergeTreesUtil(t1.left, t2.left);
            t1.right = MergeTreesUtil(t1.right, t2.right);

            return t1;
        }
    }
}
