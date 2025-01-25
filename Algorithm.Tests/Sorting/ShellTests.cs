using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting
{
	public class ShellTests
	{
		[Test]
		public void SelectionSortTest()
		{
			var arry = Helper.GetRandomizedArray(5);

			Shell.Sort(arry);
			Array.Reverse(arry);
			Assert.IsTrue(Helper.IsSortedArray(arry));
		}
	}
}
