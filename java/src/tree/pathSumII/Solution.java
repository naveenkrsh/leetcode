package tree.pathSumII;

import tree.TreeNode;

import java.util.ArrayList;
import java.util.List;

class Solution {
    public List<List<Integer>> pathSum(TreeNode root, int sum) {
        List<List<Integer>> resultSet = new ArrayList<List<Integer>>();
        pathSumUtil(root, sum, new ArrayList<Integer>(), resultSet);
        return resultSet;
    }

    private void pathSumUtil(TreeNode root, int sum, List<Integer> current, List<List<Integer>> resultSet) {

        if (root == null)
            return;
        if (root.left == null && root.right == null && (sum - root.val) == 0) {
            current.add(root.val);
            resultSet.add(new ArrayList<Integer>(current));
            current.remove(current.size() - 1);
            return;
        }

        current.add(root.val);
        if (root.left != null)
            pathSumUtil(root.left, sum - root.val, current, resultSet);
        if (root.right != null)
            pathSumUtil(root.right, sum - root.val, current, resultSet);
        current.remove(current.size() - 1);
    }
}