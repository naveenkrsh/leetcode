using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Tree;
using LeetCode.Solutions.Tree.SumRootToLeafNumbers;
namespace LeetCode.Tests.Tree.SumRootToLeafNumbers
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void Init()
        {
            sol = new Solution();
        }


        [TestMethod]
        public void ShouldReturnZeroIfTreeIsEmpty()
        {
            /*
             Input: [4,9,0,5,1]
                4
               / \
              9   0
             / \
            5   1
            Output: 1026
            Explanation:
            The root-to-leaf path 4->9->5 represents the number 495.
            The root-to-leaf path 4->9->1 represents the number 491.
            The root-to-leaf path 4->0 represents the number 40.
            Therefore, sum = 495 + 491 + 40 = 1026.
             */
          
            var actual = sol.SumNumbers(null);

            Assert.AreEqual(0, actual);
        }


        [TestMethod]
        public void ShouldReturnIfTreeIsLeftSkewed()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
          

            var actual = sol.SumNumbers(root);
           
            Assert.AreEqual(12, actual);
        }
        [TestMethod]
        public void ShouldReturnIfTreeIsRightSkewed()
        {
            TreeNode root = new TreeNode(1);

            root.right = new TreeNode(2);


            var actual = sol.SumNumbers(root);

            Assert.AreEqual(12, actual);
        }
        [TestMethod]
        public void TestCase1()
        {

            /*
            Input: [1,2,3]
                1
               / \
              2   3
            Output: 25
            Explanation:
            The root-to-leaf path 1->2 represents the number 12.
            The root-to-leaf path 1->3 represents the number 13.
            Therefore, sum = 12 + 13 = 25.
             */


            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            var actual = sol.SumNumbers(root);

            Assert.AreEqual(25, actual);
        }
        [TestMethod]
        public void TestCase2()
        {
            /*
             Input: [4,9,0,5,1]
                4
               / \
              9   0
             / \
            5   1
            Output: 1026
            Explanation:
            The root-to-leaf path 4->9->5 represents the number 495.
            The root-to-leaf path 4->9->1 represents the number 491.
            The root-to-leaf path 4->0 represents the number 40.
            Therefore, sum = 495 + 491 + 40 = 1026.
             */


            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(9);
            root.right = new TreeNode(0);
            root.left.left = new TreeNode(5);
            root.left.right = new TreeNode(1);
            var actual = sol.SumNumbers(root);

            Assert.AreEqual(1026, actual);
        }
    }

   
}
