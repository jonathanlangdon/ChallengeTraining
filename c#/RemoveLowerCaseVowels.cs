// create function to remove lowercase vowels from string

using System.Text.RegularExpressions;

public class RemoveLowerCaseVowels
{
	public static string Shortcut(string str)
	{
		return Regex.Replace(str, @"[aeiou]", "");
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Shortcut("This is an elephant on it")); //Ths s n lphnt n t
	}
}