using NUnit.Framework;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}