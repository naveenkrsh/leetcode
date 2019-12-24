package tree.pathSum;

import tree.TreeNode;

class Solution {
    public boolean hasPathSum(TreeNode root, int sum) {
        if(root == null)
            return false;
        return hasPathSumUtil(root, sum);
    }

    private boolean hasPathSumUtil(TreeNode root, int sum) {

        if (root.left == null && root.right == null)
            return (sum-root.val) == 0;

        if(root.left != null)
        {
            if (hasPathSumUtil(root.left, sum - root.val))
                return true;
        }
        if(root.right != null)
            return hasPathSumUtil(root.right, sum - root.val);

        return false;
    }
}