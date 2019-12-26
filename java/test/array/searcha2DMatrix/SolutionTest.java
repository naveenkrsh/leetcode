package array.searcha2DMatrix;

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
    public void searchMatrixTest1() {
        int[][] matrix = {
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50}
        };
        assertTrue(sol.searchMatrix(matrix, 3));
    }

    @Test
    public void searchMatrixTest2() {
        int[][] matrix = {
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50}
        };
        assertFalse(sol.searchMatrix(matrix, 13));
    }
    @Test
    public void searchMatrixTest3() {
        int[][] matrix = {{ }};
        assertFalse(sol.searchMatrix(matrix, 13));
    }
}