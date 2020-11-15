using BinaryTreeImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace BinaryTreeTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            foreach (int item in tree)
            {
                Assert.Fail("An empty tree should not enumerate any values");
            }

            tree.Contains(10).ShouldBeFalse("Tree should not contain 10 yet");

            tree.Add(10);

            tree.Contains(10).ShouldBeTrue( "Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                count.ShouldBe(1, "There should be exactly one item");
                item.ShouldBe( 10, "The item value should be 10");
            }
        }

        [TestMethod]
        public void InOrder_Enumerator()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            foreach (int actual in tree)
            {
                actual.ShouldBe(expected[index++], "The item enumerated in the wrong order");
            }
        }

    }
}
