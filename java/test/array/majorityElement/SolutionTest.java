package array.majorityElement;

import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class SolutionTest {

    Solution sol;

    @Before
    public void setUp() throws Exception {
        sol = new Solution();
    }

    @Test
    public void majorityElementTest1() {
        int[] nums = {3, 2, 3};
        int actual = sol.majorityElement(nums);

        assertEquals(3, actual);
    }

    @Test
    public void majorityElementTest2() {
        int[] nums = {2, 2, 1, 1, 1, 2, 2};
        int actual = sol.majorityElement(nums);

        assertEquals(2, actual);
    }
}