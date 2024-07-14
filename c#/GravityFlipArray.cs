// change order of array based on gravity flip direction
using System;

public class GravityFlipArray
{
	public static int[] Flip(char dir, int[] arr)
	{
		Array.Sort(arr);
		if (dir == 'L') Array.Reverse(arr);
		return arr;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", Flip('R', new int[] {3, 2, 1, 2}))); // 1, 2, 2, 3
		Console.WriteLine(string.Join(" ", Flip('L', new int[] {1, 4, 5, 3, 5}))); // 5, 5, 4, 3, 1
	}
}