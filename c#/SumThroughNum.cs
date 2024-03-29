// return the summation of all numbers 1 through the inputed numbers

using System;
using System.Linq;

public class SumThroughNum
{

	public static int summation(int num)
	{
		return Enumerable.Range(1, num).Sum();
	}


	public static void Main(string[] args)
	{
		Console.WriteLine(summation(8)); // 36
		Console.WriteLine(summation(2)); // 3
	}
}

/* using Aggregate (not needed)


		return Enumerable.Range(1, num).Aggregate(0, (a, c) => a + c);

*/