using DataStructuresTests;
using NUnit.Framework;

namespace DataStructures.Trees.Tests
{
    [TestFixture()]
    public class MinBinaryHeapTests
    {
        [Test()]
        public void Add_ValidInput_HeapifiedHeap()
        {
            var items = Helper.GetRandomArray(15, 100);
            var minHeap = new MinBinaryHeap();

            foreach (var item in items)
            {
                minHeap.Add(item);
            }

            Assert.That(minHeap.IsBalanced, Is.True);
        }
    }
}