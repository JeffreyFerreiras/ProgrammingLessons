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

            Assert.IsTrue(Helper.IsSortedArray(arry));
        }
    }
}