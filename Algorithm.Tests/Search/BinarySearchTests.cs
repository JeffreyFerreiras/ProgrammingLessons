using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture()]
    public class BinarySearchTests
    {
        public static readonly Random s_random = new Random();

        [Test()]
        public void BinSearch_TargetInArray_FindsTarget()
        {
            int[] arr = Helper.GetSortedArray(1000);
            int target = arr[s_random.Next(0, arr.Length)];

            Assert.That(arr[BinarySearch.BinSearch(arr, target)], Is.EqualTo(target));
        }

        [Test()]
        public void BinSearch_TargetInArray_ReturnsNegativeOne()
        {
            var arr = Helper.GetSortedArray(1000);
            int target = 888;

            Assert.That(arr.BinSearch(target), Is.EqualTo(-1));
        }
    }
}