// reverse order of array without altering original

using System.Collections.Generic;

public class ReverseTheList
{
	public static List<int> ReverseList(List<int> list)
	{
		return Enumerable.Reverse(list).ToList();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", ReverseList(new List<int> {1, 4}))); // 4, 1
	}
}

// other method:

// 
// List<int> newList = new List<int>(list);
// newList.Reverse();
// return newList;