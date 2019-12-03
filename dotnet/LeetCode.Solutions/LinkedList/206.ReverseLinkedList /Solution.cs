using System;
namespace LeetCode.Solutions.LinkedList.ReverseLinkedList
{

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            
            ListNode result = ReverseListRecursively(head);

            return result;
        }


        public ListNode ReverseListRecursively(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var last = ReverseListRecursively(head.next);

            head.next.next = head;
            head.next = null;
            return last;
        }

        public ListNode ReverseListIterative(ListNode head)
        {
            ListNode prev = null;
            ListNode next = null;
            ListNode current = head;

            while (current != null)
            {
                next = current.next;

                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
