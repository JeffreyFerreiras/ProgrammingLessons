namespace Algorithms.Tests
{
    using Algorithms;
    using NUnit.Framework;

    [TestFixture]
    public class BubbleSortTests
    {

        [Test]
        public void Sort_BubbleSort_OrderedArray()
        {
            int[] arry = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arry[i] = Helper.RandomNumber(i, 1000);
            }

            Bubble.BubbleSort(arry);

            Assert.IsTrue(Helper.IsSortedArray(arry));
        }
    }
}
