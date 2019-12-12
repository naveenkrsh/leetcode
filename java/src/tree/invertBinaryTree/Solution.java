package tree.invertBinaryTree;
import tree.TreeNode;

public class Solution {
    public TreeNode invertTree(TreeNode root) {
        if(root== null)
            return  null;
        invertTreeUtil(root);
        return root;
    }

    private  void invertTreeUtil(TreeNode node)
    {
        if(node==null)
           return;

        TreeNode t = node.left;
        node.left = node.right;
        node.right = t;
        invertTreeUtil(node.left);
        invertTreeUtil(node.right);
    }
}
