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
    public class MergeTests
    {
        [Test()]
        public void MergeSortTest()
        {
            int[] arry = Helper.GetRandomizedArray(100);

            arry.MergeSort();

            Assert.IsTrue(arry.IsSortedArray());
        }
    }
}