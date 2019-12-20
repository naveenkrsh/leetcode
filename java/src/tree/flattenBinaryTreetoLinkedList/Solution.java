package tree.flattenBinaryTreetoLinkedList;

import tree.TreeNode;

class Solution {
    public void flatten(TreeNode root) {
        flattenUtil(root);
    }

    private TreeNode flattenUtil(TreeNode root) {
        if (root == null)
            return null;
        TreeNode l = flattenUtil(root.left);
        TreeNode r = flattenUtil(root.right);
        if (l != null) {
            root.right = l;
            TreeNode temp = l;
            //TODO : remove this loop.
            while (temp.right != null) {
                temp = temp.right;
            }
            temp.right = r;
        } else {
            root.right = r;
        }
        root.left = null;
        return root;
    }
}