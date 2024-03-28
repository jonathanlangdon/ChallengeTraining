// return a string with the first and last characters removed

using System;

public class RemoveFirstAndLast 
{

	public static string Remove_char(string s)
	{
		return s.Substring(1, s.Length - 2);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Remove_char("world")); // "orl
	}
}