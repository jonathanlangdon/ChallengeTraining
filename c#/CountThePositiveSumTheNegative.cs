// return the count of positives and sum of negatives

using System;

public class CountThePositiveSumTheNegative
{

	public static int[] CountPositiveSumNegatives(int[] input)
	{
		if (input == null || input.Length == 0) return new int[] {};
		int SumNeg = 0;
		int CountPos = 0;
		foreach (int num in input)
		{
			if (num > 0) CountPos += 1;
			else SumNeg += num;
		}
		return new int[] {CountPos, SumNeg};
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", CountPositiveSumNegatives(null))); // [] 
		Console.WriteLine(string.Join(" ", CountPositiveSumNegatives(new int[] {}))); // [] 
		Console.WriteLine(string.Join(" ", CountPositiveSumNegatives(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, -11, -12, -13, -14, -15}))); 
		// [10, -65]
	}
}