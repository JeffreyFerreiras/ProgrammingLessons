using Algorithms.Sorting;
using NUnit.Framework;

namespace Algorithms.Tests.Sorting
{
	public class ShellTests
	{
		[Test]
		public void SelectionSortTest()
		{
			var arry = Helper.GetRandomizedArray(5);

			Shell.ShellSort(arry);
			Assert.That(Helper.IsSortedArray(arry), Is.True);
		}
	}
}
