// return array that counts by a given input

using System.Linq;

public class CountByX
{
	public static int[] CountBy(int x, int n)
	{
		return Enumerable.Range(1, n).Select(el => el * x).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", CountBy(1, 10))); // [1, 2, .... 10]
		System.Console.WriteLine(string.Join(", ", CountBy(2, 5))); // [2, 4, .... 10]
	}
}