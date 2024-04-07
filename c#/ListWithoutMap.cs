// transform an array to double every item

using System;
using System.Linq;

public class LostWithoutMap
{

	public static int[] Maps(int[] arr)
	{
		return arr.Select(x => x * 2).ToArray();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", Maps(new [] { 1, 2, 3 }))); // [2, 4, 6]
	}
}