// fix Timmy's infinite loop

using System.Linq;
using System.Collections.Generic;

public class FixTimmyInfiniteLoop
{
	public static List<int> CreateList(int number)
	{
		return Enumerable.Range(1, number).ToList();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", CreateList(3))); // 1, 2, 3
		System.Console.WriteLine(string.Join(", ", CreateList(1))); // 1
		System.Console.WriteLine(string.Join(", ", CreateList(4))); // 1, 2, 3, 4
	}
}