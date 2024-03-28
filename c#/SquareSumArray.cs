// returns the sum of the square of each item in an array

using System;
using System.Linq;

public class SquareSumArray 
{

	public static int SquareSum(int[] numbers)
	{
		return numbers.Aggregate(0, (a,c) => a + c * c);
	}

	public static void Main(string[] args) 
	{		
		Console.WriteLine(SquareSum(new int[] {1, 2, 2})); // 9
		Console.WriteLine(SquareSum(new int[] {1, 2, 3})); // 14
	}
}