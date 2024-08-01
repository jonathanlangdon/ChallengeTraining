// replace all vowels with exclamation marks

using System;
using System.Text.RegularExpressions;

public class ReplaceVowelsWithExclamation
{
	public static string Replace(string str)
	{
		return Regex.Replace(str, @"[aeiouAEIOU]", "!");
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Replace("This is it")); // Th!s !s !t
	}
}