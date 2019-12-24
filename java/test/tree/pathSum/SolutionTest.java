package tree.pathSum;

import org.junit.Before;
import org.junit.Test;
import tree.Helper;
import tree.TreeNode;

import static org.junit.Assert.*;

public class SolutionTest {
    private Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void hasPathSumTest1() {
        TreeNode root = Helper.buildTree(new Integer[]{5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1});
        boolean actual = sol.hasPathSum(root, 22);
        assertTrue(actual);
    }

    @Test
    public void hasPathSumTest2() {
        TreeNode root = Helper.buildTree(new Integer[]{5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1});
        boolean actual = sol.hasPathSum(root, 55);
        assertFalse(actual);
    }

    @Test
    public void hasPathSumTest3() {
        TreeNode root = Helper.buildTree(new Integer[]{});
        boolean actual = sol.hasPathSum(root, 0);
        assertFalse(actual);
    }

    @Test
    public void hasPathSumTest4() {
        TreeNode root = Helper.buildTree(new Integer[]{1, null, 4});
        boolean actual = sol.hasPathSum(root, 1);
        assertFalse(actual);
    }

    @Test
    public void hasPathSumTest5() {
        TreeNode root = Helper.buildTree(new Integer[]{1, null, 4});
        boolean actual = sol.hasPathSum(root, 5);
        assertTrue(actual);
    }
}