// return count of how many occurances of a character in a string

using System.Linq;

public class HowManyCharInString
{
	public static int StrCount(string str, char letter) => str.Count(x => x == letter);

	public static void Main(string[] args)
	{
		System.Console.WriteLine(StrCount("Hello", 'l')); // 2
		System.Console.WriteLine(StrCount("", 'l')); // 0
	}
}