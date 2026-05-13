// replace every char in a string with a target character

using System;
using System.Text.RegularExpressions;

public class ContaminateTheString
{

	public class Kata
	{
		public static string Contamination(string text, string character)
		{
			return Regex.Replace(text, @".", character);
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.Contamination("abc", "z"));        // expected: zzz
		Console.WriteLine(Kata.Contamination("", "z"));           // expected: 
		Console.WriteLine(Kata.Contamination("abc", String.Empty)); // expected: 
		Console.WriteLine(Kata.Contamination("_3ebzgh4", "&"));   // expected: &&&&&&&&
		Console.WriteLine(Kata.Contamination("//case", " "));     // expected:       
	}
}