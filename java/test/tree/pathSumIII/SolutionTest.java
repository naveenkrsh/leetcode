package tree.pathSumIII;

import org.junit.Before;
import org.junit.Test;
import tree.Helper;
import tree.TreeNode;

import static org.junit.Assert.*;

public class SolutionTest {

    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void pathSumTest1() {
        TreeNode root = Helper.stringToTreeNode("[10,5,-3,3,2,null,11,3,-2,null,1]");
        int actual = sol.pathSum(root, 8);
        assertEquals(3, actual);
    }

    @Test
    public void pathSumTest2() {
        TreeNode root = Helper.stringToTreeNode("[5,4,8,11,null,13,4,7,2,null,null,5,1]");
        int actual = sol.pathSum(root, 22);
        assertEquals(3, actual);
    }

    @Test
    public void pathSumTest3() {
        TreeNode root = Helper.stringToTreeNode("[0,1,1]");
        int actual = sol.pathSum(root, 1);
        assertEquals(4, actual);
    }

    @Test
    public void pathSumTest4() {
        TreeNode root = Helper.stringToTreeNode("[2]");
        int actual = sol.pathSum(root, 2);
        assertEquals(1, actual);
    }

    @Test
    public void pathSumTest5() {
        TreeNode root = Helper.stringToTreeNode("[1,0,1,1,2,0,-1,0,1,-1,0,-1,0,1,0]");
        int actual = sol.pathSum(root, 2);
        assertEquals(13, actual);
    }
}