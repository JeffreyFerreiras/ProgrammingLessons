using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture()]
    public class HeapTests
    {
        [Test()]
        public void HeapSortTest()
        {
            int[] arry = Helper.GetRandomizedArray(10, 100);

            Heap.HeapSort(arry);

            Assert.That(Helper.IsSortedArray(arry), Is.True);
        }
    }
}