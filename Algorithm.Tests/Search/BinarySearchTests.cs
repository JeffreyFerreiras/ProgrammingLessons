using NUnit.Framework;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{

    [TestFixture()]
    public class BinarySearchTests
    {
        public static readonly Random random = new Random();

        [Test()]
        public void BinSearch_TargetInArray_FindsTarget()
        {
            var arr = Helper.GetSortedArray(1000);
            int target = arr[random.Next(0, arr.Length)];

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