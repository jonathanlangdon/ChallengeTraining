// return array of integers that are power of 2 from 0 through n

using System;
using System.Linq;

public class FindAllPower2ThroughN
{
	public static long[] PowersOfTwo(int n)
	{
		return Enumerable.Range(0, n + 1).Select(x => (long) Math.Pow(2, x)).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", PowersOfTwo(3))); //[1, 2, 4, 8]
	}
}