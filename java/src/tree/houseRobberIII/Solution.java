package tree.houseRobberIII;

import tree.TreeNode;

import java.util.HashMap;
import java.util.HashSet;

class Solution {
    //TODO : last test is not passing
    public int rob(TreeNode root) {
        HashMap<TreeNode, Integer> dp = new HashMap<TreeNode, Integer>();
        return robUtil(root, dp);
    }

    private int robUtil(TreeNode root, HashMap<TreeNode, Integer> dp) {
        if (root == null)
            return 0;
        if (dp.containsKey(root))
            return dp.get(root);
        //including current
        int sum = 0;
        if (root.left != null) {
            sum += rob(root.left.left) + rob(root.left.right);
        }
        if (root.right != null) {
            sum += rob(root.right.left) + rob(root.right.right);
        }
        int including = sum + root.val;
        //excluding current
        int excluding = rob(root.left) + rob(root.right);
        int result = Math.max(including, excluding);
        dp.put(root, result);
        return dp.get(root);
    }
}