// return a string that swaps first name and last name

using System.Linq;

public class SwapFirstAndLastName
{
	public static string NameShuffler(string str)
	{
		return string.Join(" ", str.Split(" ").Reverse());
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(NameShuffler("John Smith")); // Smith John
	}
}

// using only System;

		// string[] Names = str.Split(" ");
		// Array.Reverse(Names);
		// return string.Join(" ", Names);