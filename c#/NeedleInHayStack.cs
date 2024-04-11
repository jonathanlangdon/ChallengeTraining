// return the index of where "needle" is found in an array

using System;

public class NeedleInHayStack
{

	public static string FindNeedle(object[] haystack)
	{
		return "found the needle at position " + Array.IndexOf(haystack, "needle");
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(FindNeedle(new object[]{'3', "123124234", null, "needle", "world"})); // found the needle at position 3 
	}
}