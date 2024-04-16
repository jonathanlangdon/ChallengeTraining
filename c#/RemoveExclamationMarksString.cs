// remove exclamation marks from a string

public class RemoveExclamationMarksString
{
	public static string RemoveExclamationMarks(string s) => s.Replace("!", "");

	public static void Main(string[] args)
	{
		System.Console.WriteLine(RemoveExclamationMarks("!dfj!onb!")); // dfjonb
	}
}