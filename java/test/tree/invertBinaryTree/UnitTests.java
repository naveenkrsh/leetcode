package tree.invertBinaryTree;

import org.junit.Before;
import org.junit.Test;
import org.omg.CORBA.INTERNAL;
import tree.TreeNode;
import tree.traversal.algo.ITraversal;
import tree.traversal.algo.InOrder;

import java.util.ArrayList;
import java.util.Arrays;

import static org.junit.Assert.*;

public class UnitTests {

    Solution sol;

    @Before
    public void setUp() throws Exception {
        sol = new Solution();
    }

    @Test
    public void invertTreeIfEmpty() {
        TreeNode result = sol.invertTree(null);
        assertNull(result);
    }

    @Test
    public void invertTree1() {

         /* Input
            4
           /   \
          2     7
         / \   / \
        1   3 6   9
        */

          /* Output
            4
           /   \
          7     2
         / \   / \
        9   6 3   1
        */
        TreeNode root = new TreeNode(4);
        root.left = new TreeNode(2);
        root.right = new TreeNode(7);
        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(3);
        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(9);
        ITraversal traversal = new InOrder();
        TreeNode result = sol.invertTree(root);
        ArrayList<Integer> actual = traversal.traverse(result);
        ArrayList<Integer> expected = new ArrayList<Integer>(
                Arrays.asList(9, 7, 6, 4, 3, 2, 1)
        );
        assertArrayEquals(expected.toArray(), actual.toArray());
    }

    @Test
    public void invertTree2() {
         /* Input
            4
           /
          2
        */
          /* Output
            4
             \
              2
        */
        TreeNode root = new TreeNode(4);
        root.left = new TreeNode(2);
        ITraversal traversal = new InOrder();
        TreeNode result = sol.invertTree(root);
        ArrayList<Integer> actual = traversal.traverse(result);
        ArrayList<Integer> expected = new ArrayList<Integer>(
                Arrays.asList(4, 2)
        );
        assertArrayEquals(expected.toArray(), actual.toArray());
    }
}