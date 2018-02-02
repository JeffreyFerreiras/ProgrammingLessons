using NUnit.Framework;
using System;

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

            Assert.True(arr[BinarySearch.BinSearch(arr, target)] == target);
        }

        [Test()]
        public void BinSearch_TargetInArray_ReturnsNegativeOne()
        {
            var arr = Helper.GetSortedArray(1000);
            int target = 888;

            Assert.True(arr.BinSearch(target) == -1);
        }
    }
}