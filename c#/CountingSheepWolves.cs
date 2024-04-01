// return the number of sheep in an array (true)

using System;
using System.Linq;

public class CountingSheepWolves
{
	public static int CountingSheeps(bool[] sheeps)
	{
		return sheeps.Aggregate(0, (a, c) => c ? a + 1 : a + 0);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(CountingSheeps(new bool[] { true, false, true })); // 2
	}
}