// capitalize first letter of a string

// using System.Linq;

public class CapitalizeFirstLetter
{
	public static string CapitalizeWord(string str)
	{
		return str.Substring(0,1).ToUpper() + str.Substring(1);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(CapitalizeWord("smith")); // Smith
		System.Console.WriteLine(CapitalizeWord("Smith")); // Smith
	}
}