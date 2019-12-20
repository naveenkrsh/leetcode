package tree.flattenBinaryTreetoLinkedList;

import org.junit.Before;
import org.junit.Test;
import tree.TreeNode;

import java.util.ArrayList;

import static org.junit.Assert.*;

public class SolutionTest {
    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void flatten() {
        /*
            1
           / \
          2   5
         / \   \
        3   4   6
        * */
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(5);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.right = new TreeNode(6);
        sol.flatten(root);
        int[] expected = {1, 2, 3, 4, 5, 6};
        int[] actual = traverse(root);
        assertArrayEquals(expected, actual);
    }

    private int[] traverse(TreeNode list) {
        ArrayList<Integer> l = new ArrayList<Integer>();
        TreeNode temp = list;
        while (temp != null) {
            l.add(temp.val);
            temp = temp.right;
        }
        int[] a = new int[l.size()];
        for (int i = 0; i < l.size(); i++) {
            a[i] = l.get(i);
        }
        return a;
    }
}