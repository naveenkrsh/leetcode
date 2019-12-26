package tree.pathSumIII;

import tree.TreeNode;

import java.util.ArrayList;
import java.util.Vector;

class Solution {

    private class Result {
        public int sum;

        public Result() {
            sum = 0;
        }
    }

    public int pathSum(TreeNode root, int sum) {
        Result result = new Result();
        pathSumUtil(root, sum, result, new ArrayList<TreeNode>());
        return result.sum;
    }

    private void pathSumUtil(TreeNode root, int sum, Result result, ArrayList<TreeNode> vector) {
        if (root == null)
            return;
        vector.add(root);
        pathSumUtil(root.left, sum, result, vector);
        pathSumUtil(root.right, sum, result, vector);
        int current = 0;
        for (int i = vector.size() - 1; i >= 0; i--) {
            current += vector.get(i).val;
            if (current == sum) {
                result.sum++;
            }
        }
        vector.remove(vector.size() - 1);
    }
}