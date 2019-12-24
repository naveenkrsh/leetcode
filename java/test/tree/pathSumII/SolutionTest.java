package tree.pathSumII;

import org.junit.Before;
import org.junit.Test;
import tree.Helper;
import tree.TreeNode;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.*;

public class SolutionTest {
    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void pathSumTest1() {
        String input = "[5,4,8,11,null,13,4,7,2,null,null,5,1]";
        TreeNode root = Helper.stringToTreeNode(input);
        List<List<Integer>> actual = sol.pathSum(root, 22);
        List<List<Integer>> expected = Arrays.asList(
                Arrays.asList(5, 4, 11, 2),
                Arrays.asList(5, 8, 4, 5)
        );
        assertThat(actual, is(expected));
    }
    @Test
    public void pathSumTest2() {
        String input = "[]";
        TreeNode root = Helper.stringToTreeNode(input);
        List<List<Integer>> actual = sol.pathSum(root, 1);
        List<List<Integer>> expected = new ArrayList<List<Integer>>();
        assertThat(actual, is(expected));
    }
    @Test
    public void pathSumTest3() {
        String input = "[-2,null,-3]";
        TreeNode root = Helper.stringToTreeNode(input);
        List<List<Integer>> actual = sol.pathSum(root, -5);
        List<List<Integer>> expected = Arrays.asList(
                Arrays.asList(-2, -3)
        );
        assertThat(actual, is(expected));
    }

}