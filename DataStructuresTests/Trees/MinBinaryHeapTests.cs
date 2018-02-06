using NUnit.Framework;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresTests;

namespace DataStructures.Trees.Tests
{
    [TestFixture()]
    public class MinBinaryHeapTests
    {
        [Test()]
        public void AddTest()
        {
            var items = Helper.GetRandomArray(10);
            var minHeap = new MinBinaryHeap();

            foreach(var item in items)
            {
                minHeap.Add(item);
            }
        }
    }
}