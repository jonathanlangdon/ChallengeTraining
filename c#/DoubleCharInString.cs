// repeat each character in a string

using System.Linq;

public class DoubleCharInString
{
	public static string DoubleChar(string s) => string.Join("", s.ToCharArray().Select(x => $"{x}{x}"));

	public static void Main(string[] args)
	{
		System.Console.WriteLine(DoubleChar("this")); // tthhiiss
	}
}

/* other ways:
string.Join("", s.Select(x => "" + x + x));
string.Concat(s.Select(x => $"{x}{x}"));
*/