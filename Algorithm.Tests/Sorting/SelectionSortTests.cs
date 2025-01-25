using NUnit.Framework;

namespace Algorithms.Tests
{
	[TestFixture]
	public class SelectionSortTests
	{
		[Test]
		public void SelectionSortTest()
		{
			var arry = Helper.GetRandomizedArray(5);

			Selection.Sort(arry);

			Assert.That(Helper.IsSortedArray(arry), Is.True);
		}
	}
}
