// given a number, count from 1 to that number

using System.Linq;

public class CountMonkeyUpToN 
{
	public static int[] MonkeyCount(int n) => Enumerable.Range(1, n).ToArray();

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", MonkeyCount(5))); // [1, 2, 3, 4, 5]
	}
}