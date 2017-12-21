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
        [Test()]
        public void ContainsTest()
        {
            var tree = new BinarySearchTree();


        }

        [Test()]
        public void AddTest()
        {
            var tree = new BinarySearchTree();

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
        }
    }
}