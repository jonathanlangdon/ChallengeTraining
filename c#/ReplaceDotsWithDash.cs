// replace all '.' with '-' in string

public class ReplaceDotsWithDash
{
	public static string ReplaceDots(string str)
	{
		return str.Replace(".", "-");
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ReplaceDots("Really... You did it.")); // Really--- You did it-
	}
}