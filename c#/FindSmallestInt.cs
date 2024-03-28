// return the smallest integer in an array

using System;
using System.Linq;

public class FindSmallestInteger 
{

	public static int FindSmallestInt(int[] arr) => arr.Min();

	public static void Main(string[] args)
	{
		Console.WriteLine(FindSmallestInt(new int[] {5, 34, 15, 3})); // 3
	}
}


/* alternative way:

		int[] sortedArr = arr.ToArray();
		Array.Sort(sortedArr);
		return sortedArr[0];

*/