// remove duplicates, but keep order
using System.Linq;
using System.Collections.Generic;

public class RemoveDuplicatesKeepOrder
{
	public static int [] distinct(int[] arr)
	{
		List<int> NumList = new List<int>();
		foreach (int num in arr)
		{
			if (NumList.Contains(num)) continue;
			else NumList.Add(num);
		}
		return NumList.ToArray();
	}


	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(" ", distinct(new int[] {1, 1, 2}))); // 1, 2
		System.Console.WriteLine(string.Join(" ", distinct(new int[] {1, 2, 1, 1, 3, 2}))); // 1, 2, 3
	}
}