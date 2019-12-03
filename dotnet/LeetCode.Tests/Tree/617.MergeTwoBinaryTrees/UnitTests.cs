using System;
using LeetCode.Solutions.Tree;
using LeetCode.Solutions.Tree.MergeTwoBinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Tree.MergeTwoBinaryTrees
{
    [TestClass]
    public class UnitTests
    {
        Solution sol;
        [TestInitialize]
        public void UnitTestsInit()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void TestCase1()
        {
            /*
             Input: 
                Tree 1                     Tree 2                  
                      1                         2                             
                     / \                       / \                            
                    3   2                     1   3                        
                   /                           \   \                      
                  5                             4   7                  
            Output: 
            Merged tree:
                     3
                    / \
                   4   5
                  / \   \ 
                 5   4   7

             */
            var tree1 = new TreeNode(1);
            tree1.left = new TreeNode(3);
            tree1.right = new TreeNode(2);
            tree1.left.left = new TreeNode(5);



            var tree2 = new TreeNode(2);
            tree2.left = new TreeNode(1);
            tree2.right = new TreeNode(3);

            tree2.left.right = new TreeNode(4);
            tree2.right.right = new TreeNode(7);

            var result = sol.MergeTrees(tree1, tree2);

            Assert.AreEqual(result.val, 3);
            Assert.AreEqual(result.left.val, 4);
            Assert.AreEqual(result.right.val, 5);
            Assert.AreEqual(result.left.left.val, 5);
            Assert.AreEqual(result.left.right.val, 4);
            Assert.AreEqual(result.right.right.val, 7);
           
        }

        


    }
}
