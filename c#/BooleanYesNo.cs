// takes boolean input and returns Yes or No

using System;

public static class BooleanYesNo 
{

	public static string boolToWord(bool word)
	{
		return word ? "Yes" : "No";
	}

	public static void Main(string[] args) 
	{
		Console.WriteLine(boolToWord(true));
	}
}