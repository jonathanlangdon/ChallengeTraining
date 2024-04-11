// find the max and min of an array

using System;
using System.Linq;

public class MaxAndMinFunctions
{

	public static int Min(int[] list)
	{
		return list.Min();
	}

	public static int Max(int[] list)
	{
		return list.Max();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Min(new int[] {4,6,2,1,9,63,-134,566})); // -134
		Console.WriteLine(Max(new int[] {4,6,2,1,9,63,-134,566})); // 566
	}
}