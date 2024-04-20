// reverse the order of words in a string

using System.Linq;

public class ReverseWordsInString
{
	public static string ReverseWords(string str) => string.Join(" ", str.Split(" ").Reverse());

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ReverseWords("Turn this around")); // "around this Turn"
	}
}