package array.findAllNumbersDisappearedinanArray;

import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class SolutionTest {

    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void findDisappearedNumbersTest1() {
        int[] input = {4, 3, 2, 7, 8, 2, 3, 1};
        List<Integer> actual = sol.findDisappearedNumbers(input);
        List<Integer> expected = new ArrayList<Integer>();
        expected.add(5);
        expected.add(6);
        assertArrayEquals(expected.toArray(), actual.toArray());
    }

    @Test
    public void findDisappearedNumbersTest2() {
        int[] input = {};
        List<Integer> actual = sol.findDisappearedNumbers(input);
        List<Integer> expected = new ArrayList<Integer>();
        assertArrayEquals(expected.toArray(), actual.toArray());
    }
}