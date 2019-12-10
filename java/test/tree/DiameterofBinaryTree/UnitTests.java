package tree.DiameterofBinaryTree;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import tree.TreeNode;

import static org.junit.Assert.*;

public class UnitTests {

    Solution sol;

    @Before
    public void setUp() throws Exception {
        sol = new Solution();
    }

    @Test
    public void diameterOfBinaryTree1() {
        /*
          1
         / \
        2   3
       / \
      4   5
        */
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        int actual = sol.diameterOfBinaryTree(root);
        assertEquals(3, actual);
    }

    @Test
    public void diameterOfBinaryTree2() {
        /*
              1
             /
            2
           / \
          4   5
         /      \
        6        7
       */
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        //root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.left.left.left = new TreeNode(6);
        root.left.right.right = new TreeNode(7);
        int actual = sol.diameterOfBinaryTree(root);
        assertEquals(4, actual);
    }

    @Test
    public void diameterOfBinaryTree3() {
        /*
              1
       */
        TreeNode root = new TreeNode(1);
        int actual = sol.diameterOfBinaryTree(root);
        assertEquals(0, actual);
    }

    @Test
    public void diameterOfBinaryTree4() {
        int actual = sol.diameterOfBinaryTree(null);
        assertEquals(0, actual);
    }

    @Test
    public void diameterOfBinaryTree5() {
        /*
              1
             /
            2
       */
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        int actual = sol.diameterOfBinaryTree(root);
        assertEquals(1, actual);
    }
}