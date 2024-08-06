// abbreviate a two word name

using System;

public class AbbreviateTwoWordName
{

	public static string AbbrevName(string name)
	{
		string[] nameArr = name.Split();
		return $"{nameArr[0][0]}.{nameArr[1][0]}".ToUpper();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(AbbrevName("Sam Harris")); //S.H
		Console.WriteLine(AbbrevName("sam harris")); //S.H
	}
}