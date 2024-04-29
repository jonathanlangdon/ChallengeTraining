// create an array of all integers between two inputed numbers

using System.Linq;

public class AllIntegersBetween
{
	public static int[] Between(int a, int b)
	{
		return Enumerable.Range(a, b - a + 1).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", Between(0, 2))); // [0, 1, 2]
		System.Console.WriteLine(string.Join(", ", Between(-2, 1))); // [-2, -1, 0, 1]
	}
}