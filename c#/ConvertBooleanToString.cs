// convert boolean values to string representation

using System;

public class ConvertBooleanToString
{

	public static string BooleanToString(bool b) => b ? "True" : "False";

	public static void Main(string[] args)
	{
		Console.WriteLine(BooleanToString(true)); // "True"
	}
}