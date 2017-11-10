namespace Algorithms.Tests
{
    using Algorithms;
    using NUnit.Framework;
    using System;
    using System.Diagnostics;

    [TestFixture]
    public class BubbleSortTests
    {

        [Test]
        public void Sort_BubbleSort_OrderedArray()
        {
            int[] arry = Helper.GetRandomizedArray(1000);
            
            Bubble.BubbleSort(arry);

            Assert.IsTrue(Helper.IsSortedArray(arry));
        }

        [Test]
        public void Sort_BubbleSortSpeedTest_OrderedArrays()
        { 
            Stopwatch watch = new Stopwatch();

            int[] arry = Helper.GetRandomizedArray(1000);
            int[] arry2 = new int[arry.Length];

            Array.Copy(arry, arry2, arry.Length);

            watch.Start();
            Bubble.BubbleSort(arry);
            watch.Stop();
            Debug.WriteLine("SORT 1 " + watch.ElapsedTicks.ToString());

            watch.Reset();
            watch.Start();
            Bubble.BubbleSort2(arry2);
            watch.Stop();

            Debug.WriteLine("SORT 2 " + watch.ElapsedTicks.ToString());

            Assert.IsTrue(Helper.IsSortedArray(arry) && Helper.IsSortedArray(arry2));
        }
    }
}
