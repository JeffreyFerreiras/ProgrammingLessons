using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Disassemblers;
using CommandLine.Text;
using System.Xml.Linq;

namespace Algorithms.Sorting
{
	public class Shell
	{



		/// <summary>
		/// Shell sort is an unstable quadratic sorting algorithm, which can be seen as a generalization of insertion sort. Althrought is has an O(n^2) asymptotic complexity, it is the most efficient algorithm of this class.
		/// <remarks>
		/// An ordinary insertion sort maintains a list of already sorted elements. 
		/// Than it picks the element next to the list and places it at the correct position within the list.
		/// By iteratively repeating this procedure (starting with a list of one element) the array gets sorted in n steps.
		/// Shell sort operates analogously.The main difference is, that Shell sort uses so called diminishing increment.
		/// It means that in every step only elements at some distance are compared 
		/// (for example the first with the fifth, second with the sixth...).
		/// This approach ensures that elements with high and low value are moved to the appropriate side of the array very quickly.
		/// In every iteration the gap between the compared elements is reduced.
		/// In the iteration step, the gap is set to one – the algorithm degrades to an ordinary insertion sort,
		/// which terminates very quickly, because now the array contains only few misplaced elements.
		/// </remarks>
		/// <params ></params>
		/// </summary>
		
		public static int[] Sort(int[] array)
		{
			int gap = array.Length / 2;
			while (gap > 0)
			{
				for (int i = 0; i < array.Length - gap; i++)
				{
					//modified insertion sort
					int j = i + gap;
					int value = array[j];
					while (j >= gap && value > array[j - gap])
					{
						array[j] = array[j - gap];
						j -= gap;
					}
					array[j] = value;
				}
				if (gap == 2)
				{ //change the gap size
					gap = 1;
				}
				else
				{
					gap = (int)(gap / 2.2);
				}
			}
			return array;
		}
	}
}
