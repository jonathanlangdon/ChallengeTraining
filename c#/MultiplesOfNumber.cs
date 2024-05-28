// return list of integers that are a multiple of a given input up to a given max

using System.Collections.Generic;
using System.Linq;

public class MultiplesOfNumber
{
	public static List<int> FindMultiples(int integer, int limit)
	{
		return Enumerable.Range(1, limit / integer).Select(x => x * integer).ToList();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", FindMultiples(2, 6))); // [2, 4, 6]
		System.Console.WriteLine(string.Join(", ", FindMultiples(2, 5))); // [2, 4]
	}
}