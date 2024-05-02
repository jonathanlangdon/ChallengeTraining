// switch all lowercase to uppercase and vice versa

using System.Linq;

public class AllLettersAlternatingCase
{
	public static string ToAlternatingCase(string str)
	{
		return string.Concat(str.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ToAlternatingCase("ThiS2")); // tHIs2
	}
}