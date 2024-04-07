// remove all spaces from a string

using System;

public class RemoveStringSpaces
{

	public static string NoSpace(string input) => input.Replace(" ", "");

	public static void Main(string[] args)
	{
		Console.WriteLine(NoSpace(" this should have no 8 Spaces")); // "thisshouldhaveno8Spaces"
	}
}