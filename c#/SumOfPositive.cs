// return the sum of all the positive items in an array

using System;
using System.Linq;

public class SumOfPositive 
{

	public static int PositiveSum(int[] arr)
	{
		return arr.Aggregate(0, (a, c) => c > 0 ? a + c : a);
	}

	public static void Main(string[] args) 
	{
		Console.WriteLine(PositiveSum(new int[]{-1, 2, 3, 4, -5})); // 9
	}
}