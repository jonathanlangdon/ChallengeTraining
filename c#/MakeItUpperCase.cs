// convert an input string to uppercase

using System;

public class MakeItUpperCase
{

	public static string MakeUpperCase(string str) => str.ToUpper();

	public static void Main(string[] args)
	{
		Console.WriteLine(MakeUpperCase("This is it")); //THIS IS IT
	}
}