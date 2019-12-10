package tree.DiameterofBinaryTree;

import tree.TreeNode;

class Solution {
    public int diameterOfBinaryTree(TreeNode root) {

        if(root == null)
            return 0;
        Height h = new Height();
        diameterOfBinaryTreeUtil(root,h);

        return h.height-1;
    }

    private int diameterOfBinaryTreeUtil(TreeNode root,Height ans) {
        if (root == null)
            return 0;

        int l = diameterOfBinaryTreeUtil(root.left,ans);
        int r = diameterOfBinaryTreeUtil(root.right,ans);

        ans.height = Math.max(ans.height,l+r+1);
        return 1+Math.max(l,r);
    }

    class Height
    {
        public int height;

        public Height()
        {
            height = 0;
        }
    }
}