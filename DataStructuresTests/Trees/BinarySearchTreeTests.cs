using NUnit.Framework;
using System;
using System.Diagnostics;

namespace DataStructures.Trees.Tests
{
    [TestFixture()]
    public class BinarySearchTreeTests
    {
        private BinarySearchTree BinTreeFactory()
        {
            int[] sample = { 212, 580, 6, 7, 28, 84, 112, 434 };

            BinarySearchTree bst = new BinarySearchTree();

            foreach(int x in sample)
            {
                bst.Add(x);
            }

            return bst;
        }

        [Test()]
        public void ContainsTest()
        {
            var tree = BinTreeFactory();

            Assert.IsTrue(tree.Contains(6));
        }

        [Test()]
        public void AddTest()
        {
            int[] sample = { 212, 580, 6, 7, 28, 84, 112, 434 };

            BinarySearchTree bst = new BinarySearchTree();

            foreach(int x in sample)
            {
                bst.Add(x);
            }
        }

        [Test()]
        public void RemoveTest()
        {
            var bst = BinTreeFactory();

            bst.Remove(6);

            Assert.IsFalse(bst.Contains(6));
        }

        [Test()]
        public void MinTest()
        {
            var bst = BinTreeFactory();

            Assert.IsTrue(bst.Min() == 6);
        }

        [Test()]
        public void MaxTest()
        {
            var bst = BinTreeFactory();

            Assert.IsTrue(bst.Max() == 580);
        }

        [Test()]
        public void TraverseInOrderTest()
        {
            var bst = BinTreeFactory();

            Action<Node> action = (x) =>
            {
                Debug.Print($"Node value: {x.Value} \tIs Leaf: {x.IsLeafNode}");
            };

            bst.TraverseInOrder(action);
        }

        [Test()]
        public void LeafCountTest()
        {
            var bst = BinTreeFactory();

            Assert.IsTrue(bst.LeafCount() > 0);
        }
    }
}