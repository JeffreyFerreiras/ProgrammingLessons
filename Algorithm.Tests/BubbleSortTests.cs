using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    using Algorithms;

    [TestClass]
    public class BubbleSortTests
    {

        [TestMethod]
        public void Sort_BubbleSort_OrderedArray()
        {
            int[] arry = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arry[i] = Helper.RandomNumber(i, 1000);
            }

            BubbleSort.Sort(arry);

            Assert.IsTrue(Helper.IsSortedArray(arry));
        }
    }
}
