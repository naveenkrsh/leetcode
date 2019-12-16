package linkedlist.mergeTwoSortedLists;

import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;

import static org.junit.Assert.*;

public class SolutionTest {
    Solution sol;

    @Before
    public void setUp() {
        sol = new Solution();
    }

    @Test
    public void mergeTwoListsTest1() {

        ListNode l1 = new ListNode(1);
        ListNode l2 = new ListNode(2);

        ListNode result = sol.mergeTwoLists(l1, l2);
        int[] expected = {1, 2};
        int[] actual = traverse(result);
        assertArrayEquals(expected, actual);
    }

    @Test
    public void mergeTwoListsTest2() {

        ListNode l1 = new ListNode(1);
        ListNode l2 = new ListNode(1);

        ListNode result = sol.mergeTwoLists(l1, l2);
        int[] expected = {1, 1};
        int[] actual = traverse(result);
        assertArrayEquals(expected, actual);
    }

    @Test
    public void mergeTwoListsTest3() {

        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);

        ListNode l2 = new ListNode(3);
        l2.next = new ListNode(4);

        ListNode result = sol.mergeTwoLists(l1, l2);
        int[] expected = {1, 2, 3, 4};
        int[] actual = traverse(result);
        assertArrayEquals(expected, actual);
    }

    @Test
    public void mergeTwoListsTest4() {

        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(3);

        ListNode l2 = new ListNode(2);
        l2.next = new ListNode(4);

        ListNode result = sol.mergeTwoLists(l1, l2);
        int[] expected = {1, 2, 3, 4};
        int[] actual = traverse(result);
        assertArrayEquals(expected, actual);
    }

    private int[] traverse(ListNode list) {
        ArrayList<Integer> l = new ArrayList<Integer>();

        ListNode temp = list;
        while (temp != null) {
            l.add(temp.val);
            temp = temp.next;
        }

        int[] a = new int[l.size()];
        for (int i = 0; i < l.size(); i++) {
            a[i] = l.get(i);
        }
        return a;
    }
}