// return an array of values that are inversed numerically

using System;
using System.Linq;

public class InvertNumberValues
{

	public static int[] InvertValues(int[] input) => input.Select(n => -n).ToArray();

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", InvertValues(new int[] {-1, 2, 3, -4, -5}))); // [1, -2, -3, 4, 5]
	}
}