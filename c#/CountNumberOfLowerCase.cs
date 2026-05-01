// count the number of lowercase characters

using System;
using System.Text.RegularExpressions; 

public class CountNumberOfLowerCase
{
	public class Kata
	{
		public static int LowercaseCountCheck(string s)
		{
			return Regex.Replace(s, @"[^a-z]", "").Length;
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.LowercaseCountCheck("abc")); // expected: 3
		Console.WriteLine(Kata.LowercaseCountCheck("abcABC123")); // expected: 3
		Console.WriteLine(Kata.LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|\\':;?/>.<,~")); // expected: 3
		Console.WriteLine(Kata.LowercaseCountCheck("")); // expected: 0
		Console.WriteLine(Kata.LowercaseCountCheck("ABC123!@€£#$%^&*()_-+=}{[]|\\':;?/>.<,~")); // expected: 0
		Console.WriteLine(Kata.LowercaseCountCheck("abcdefghijklmnopqrstuvwxyz")); // expected: 26
	}
}
