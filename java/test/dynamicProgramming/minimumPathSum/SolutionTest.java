package dynamicProgramming.minimumPathSum;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class SolutionTest {

    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void minPathSumTest1() {
        int[][] input = {{1, 3, 1}, {1, 5, 1}, {4, 2, 1}};
        int actual = sol.minPathSum(input);
        assertEquals(7, actual);
    }

    @Test
    public void minPathSumTest2() {
        int[][] input = {{1, 3, 1}};
        int actual = sol.minPathSum(input);
        assertEquals(5, actual);
    }

    @Test
    public void minPathSumTest3() {
        int[][] input = {{1}, {3}, {1}};
        int actual = sol.minPathSum(input);
        assertEquals(5, actual);
    }

    @Test
    public void minPathSumTest4() {
        int[][] input = {{1}};
        int actual = sol.minPathSum(input);
        assertEquals(1, actual);
    }

    @Test
    public void minPathSumTest5() {
        int[][] input = {};
        int actual = sol.minPathSum(input);
        assertEquals(0, actual);
    }
}