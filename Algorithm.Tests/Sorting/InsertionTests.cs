using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tests;
using NUnit.Framework;

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
    }
}