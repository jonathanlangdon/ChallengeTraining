// remove exclamation from end of string

using System.Linq;

public class RemoveExclamationLastChar
{
	public static string Remove(string str)
	{
		return str.Last() == '!' ? str.Substring(0, str.Length - 1) : str;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Remove("Th!is!")); // Th!is
		System.Console.WriteLine(Remove("Th!at")); // Th!at
	}
}