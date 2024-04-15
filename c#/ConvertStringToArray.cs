// convert a string to an array

using System;

public class ConvertStringToArray
{
	public static string[] StringToArray(string str) => str.Split(" ");

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", StringToArray("This is easy"))); // ["This", "is", "easy"]
	}
}