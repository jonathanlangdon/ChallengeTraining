// input 2 strings and return short+long+short with shorter strings on outside

public class ShortLongShort
{
	public static string Solution(string a, string b)
	{
		return a.Length > b.Length ? b + a + b : a + b + a;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Solution("1", "22")); // 1221
		System.Console.WriteLine(Solution("22", "1")); // 1221
	}
}