package array.productofArrayExceptSelf;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class SolutionTest {
    Solution sol;
    @Before
    public  void setUp() throws Exception{
        sol = new Solution();
    }
    @Test
    public void productExceptSelfTest1() {
        int[] nums = {1,2,3,4};
        int[] actual = sol.productExceptSelf(nums);
        int[] expected = {24,12,8,6};
        assertArrayEquals(expected,actual);
    }

    @Test
    public void productExceptSelfTest2() {
        int[] nums = {1};
        int[] actual = sol.productExceptSelf(nums);
        int[] expected = {1};
        assertArrayEquals(expected,actual);
    }

    @Test
    public void productExceptSelfTest3() {
        int[] nums = {};
        int[] actual = sol.productExceptSelf(nums);
        int[] expected = {};
        assertArrayEquals(expected,actual);
    }

    @Test
    public void productExceptSelfTest4() {

        int[] actual = sol.productExceptSelf(null);
        assertArrayEquals(null,actual);
    }
}