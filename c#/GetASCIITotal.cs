// calculate the addition of all the ASCII characters values

using System.Linq;

public static class GetASCIITotal {
	public static int UniTotal(string str)
	{
		return str.Select(c => (int)c ).Sum();
	}

	public static void Main()
	{
		System.Console.WriteLine(UniTotal("aaa")); // 291
	}
}
