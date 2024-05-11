// sum two string integers and output a string integer

public class SumStringNumbers
{
	public static string StringsSum(string s1, string s2)
	{
		if (s1 == "") s1 = "0";
		if (s2 == "") s2 = "0";
		return (int.Parse(s1) + int.Parse(s2)).ToString();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(StringsSum("", "")); // 0
		System.Console.WriteLine(StringsSum("", "4")); // 4
		System.Console.WriteLine(StringsSum("3", "")); // 3
		System.Console.WriteLine(StringsSum("3", "4")); // 7
	}
}