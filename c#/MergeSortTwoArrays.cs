// merge 2 arrays, remove duplicates, and sort

using System;
using System.Collections.Generic;
using System.Linq;

public class MergeSortTwoArrays
{
	public static int[] MergeArrays(int[] arr1, int[] arr2)
	{
		HashSet<int> numbers = new HashSet<int>();
		numbers.UnionWith(arr1);
		numbers.UnionWith(arr2);
		int[] sortedArray = numbers.ToArray();
		Array.Sort(sortedArray);
		return sortedArray;
	}

	public static void Main()
	{
		System.Console.WriteLine(string.Join(", ", MergeArrays(new int[] {1, 3, 4}, new int[] {3, 2, 1}))); // 1, 2, 3, 4)
	}
}