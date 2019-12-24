package tree.houseRobberIII;

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
    public void robTest1() {
        TreeNode root = Helper.stringToTreeNode("[3, 2, 3, null, 3, null, 1]");
        /*
      3
    / \
   2   3
    \   \
     3   1
*/
        int actual = sol.rob(root);
        assertEquals(7, actual);

    }

    @Test
    public void robTest2() {
        TreeNode root = Helper.stringToTreeNode("[3, 4, 5, 1, 3, null, 1]");
        int actual = sol.rob(root);
        assertEquals(9, actual);

    }
//
}