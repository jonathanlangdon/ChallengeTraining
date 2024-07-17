// take a string and return word lengths in an array
using System.Collections.Generic;

public class WordsToWordLengthArray
{
	public static string[] AddLength(string str)
	{
		string[] StringArr = str.Split(" ");
		List<string> WordLengthList = new List<string>();
		foreach (string word in StringArr)
		{
			WordLengthList.Add($"{word} {word.Length}");
		}
		return WordLengthList.ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(" ", AddLength("apple ban"))); // "apple 5", "ban 3"
	}
}