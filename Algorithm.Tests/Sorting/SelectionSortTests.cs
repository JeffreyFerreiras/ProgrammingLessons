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

			Assert.IsTrue(Helper.IsSortedArray(arry));
		}
	}
}
