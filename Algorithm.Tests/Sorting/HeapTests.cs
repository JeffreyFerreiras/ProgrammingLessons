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