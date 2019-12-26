package stack.decodeString;

import org.junit.Before;
import org.junit.Test;

import java.io.Console;

import static org.junit.Assert.*;

public class SolutionTest {

    private Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void decodeStringTest1() {
        String actual = sol.decodeString("3[a]2[bc]");
        String expected = "aaabcbc";
        assertEquals(expected, actual);
    }

    @Test
    public void decodeStringTest2() {
        String actual = sol.decodeString("3[a2[c]]");
        String expected = "accaccacc";
        assertEquals(expected, actual);
    }

    @Test
    public void decodeStringTest3() {
        String actual = sol.decodeString("2[abc]3[cd]ef");
        String expected = "abcabccdcdcdef";
        assertEquals(expected, actual);
    }

    @Test
    public void decodeStringTest4() {
        String actual = sol.decodeString("10[a]");
        String expected = multipleStr(10,"a");
        assertEquals(expected, actual);
    }
    @Test
    public void decodeStringTest5() {
        String actual = sol.decodeString("100[a]");
        String expected = multipleStr(100,"a");
        assertEquals(expected, actual);
    }
    @Test
    public void decodeStringTest6() {
        String actual = sol.decodeString("99[a]");
        String expected = multipleStr(99,"a");
        assertEquals(expected, actual);
    }

    private String multipleStr(int times, String s) {
        String str = "";
        for (int i = 0; i < times; i++) {
            str += s;

        }
        return  str;
    }
}