using NUnit.Framework;

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

            Assert.That(arry.IsSorted(), Is.True);
        }
    }
}