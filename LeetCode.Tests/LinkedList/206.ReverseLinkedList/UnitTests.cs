using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.LinkedList;
using LeetCode.Solutions.LinkedList.ReverseLinkedList;
using System.Collections.Generic;

namespace LeetCode.Tests.LinkedList.ReverseLinkedList
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        ListNode head;
        List<int> expected ;

        [TestInitialize]
        public void UnitTestsInit()
        {
            sol = new Solution();
            head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            expected = new List<int> { 5, 4, 3, 2, 1 };
        }


        [TestMethod]
        public void ShouldReverseRecursively()
        {
            //Input: 1->2->3->4->5->NULL
            //Output: 5->4->3->2->1->NULL
            

            var actualHead = sol.ReverseListRecursively(head);
            var actualCurrent = actualHead;


            int index = 0;
           
            while (actualCurrent != null)
            {
                Assert.AreEqual(expected[index], actualCurrent.val);

                actualCurrent = actualCurrent.next;
                index++;
            }

        }

        [TestMethod]
        public void ShouldReverseRecursivelyForEmpty()
        {
            
            var actualHead = sol.ReverseListRecursively(null);
           
            Assert.IsNull(actualHead);
        }

        [TestMethod]
        public void ShouldReverseIterative()
        {
            //Input: 1->2->3->4->5->NULL
            //Output: 5->4->3->2->1->NULL


            var actualHead = sol.ReverseListIterative(head);
            var actualCurrent = actualHead;


            int index = 0;

            while (actualCurrent != null)
            {
                Assert.AreEqual(expected[index], actualCurrent.val);

                actualCurrent = actualCurrent.next;
                index++;
            }

        }


        [TestMethod]
        public void ShouldReverseIterativeForEmpty()
        {

            var actualHead = sol.ReverseListIterative(null);

            Assert.IsNull(actualHead);
        }
    }
}
