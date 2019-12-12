package tree.traversal.algo;

import tree.TreeNode;

import java.util.ArrayList;

public class InOrder implements ITraversal {
    @Override
    public ArrayList<Integer> traverse(TreeNode root) {
        ArrayList<Integer> result = new ArrayList<Integer>();
        fillArray(root, result);
        return result;
    }

    private void fillArray(TreeNode root, ArrayList<Integer> result) {
        if (root == null)
            return;
        fillArray(root.left, result);
        result.add(root.val);
        fillArray(root.right, result);
    }
}
