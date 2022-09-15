using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

			Shell.Sort(arry);
			Array.Reverse(arry);
			Assert.IsTrue(Helper.IsSortedArray(arry));
		}
	}
}
