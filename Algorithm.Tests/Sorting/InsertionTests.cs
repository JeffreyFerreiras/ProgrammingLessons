using Algorithms.Tests;

namespace Algorithms.Sorting.Tests
{
    [TestFixture]
    public class InsertionTests
    {
        [Test]
        public void InsertionSort_SortIntArray_SortedArray()
       {
            var arry = Helper.GetRandomizedArray(7);
            //var arry = new int [] { 5, 4, 3, 2, 1 };

            arry.InsertionSort();
            Assert.True(Helper.IsSortedArray(arry));
        }

        [Test()]
        public void SortTest()
        {
            var arry = Helper.GetRandomizedArray(7);
            //var arry = new int [] { 5, 4, 3, 2, 1 };

            Insertion.Sort(arry);

            Assert.True(Helper.IsSortedArray(arry));
        }
    }
}