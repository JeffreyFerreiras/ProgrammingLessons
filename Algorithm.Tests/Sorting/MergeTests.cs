namespace Algorithms.Tests
{
    [TestFixture()]
    public class MergeTests
    {
        [Test()]
        public void MergeSortTest()
        {
            int[] arry = Helper.GetRandomizedArray(100);

            arry.MergeSort();

            Assert.IsTrue(arry.IsSorted());
        }
    }
}