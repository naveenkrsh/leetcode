package dynamicProgramming.uniqueBinarySearchTrees;

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
    public void numTreesTest1() {
        assertEquals(5, sol.numTrees(3));
    }

    @Test
    public void numTreesTest2() {
        assertEquals(14, sol.numTrees(4));
    }

    @Test
    public void numTreesTest3() {
        assertEquals(429, sol.numTrees(7));
    }

    @Test
    public void numTreesTest4() {
        assertEquals(58786, sol.numTrees(11));
    }

    @Test
    public void numTreesTest5() {
        assertEquals(1767263190, sol.numTrees(19));
    }
}
