package tree.flattenBinaryTreetoLinkedList;

import tree.TreeNode;

class Solution {
    public void flatten(TreeNode root) {
        flattenUtil(root);
    }

    private TreeNode flattenUtil(TreeNode root) {
        if (root == null)
            return null;
        TreeNode lastL = flattenUtil(root.left);
        TreeNode lastR = flattenUtil(root.right);

        if (lastL == null && lastR == null)
            return root;

        if (lastL != null) {
            lastL.right = root.right;
            root.right = root.left;
            root.left = null;
        }
        if (lastR != null)
            return lastR;
        if (lastL != null)
            return lastL;
        return root;
    }
}