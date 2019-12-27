package array.searcha2DMatrixII;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class SolutionTest {

    private Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void searchMatrixTest1() {
        int[][] matrix = {{}};
        assertFalse(sol.searchMatrix(matrix, 1));
    }

    @Test
    public void searchMatrixTest2() {
        int[][] matrix = {
                {1,   4,  7, 11, 15},
                {2,   5,  8, 12, 19},
                {3,   6,  9, 16, 22},
                {10, 13, 14, 17, 24},
                {18, 21, 23, 26, 30}
        };
        assertTrue(sol.searchMatrix(matrix, 5));
        assertFalse(sol.searchMatrix(matrix, 20));
    }
}