using System;
using Algorithms;
using NUnit.Framework;

namespace Algorithms.Tests
{

	[TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void QuickSort_SortArray_SortedArray()
        {
            var arry = Helper.GetRandomizedArray(1000);

            arry.QuickSort();

            Assert.IsTrue(Helper.IsSortedArray(arry));
        }

		[Test]
		public void QuickSort_Practice()
		{
			var arry = Helper.GetRandomizedArray(15);

			arry.QuickSort();

			Assert.IsTrue(Helper.IsSortedArray(arry));
		}
	}
}
