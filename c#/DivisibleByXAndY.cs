// return whether a number is divisble by two inputs

public class DivisibleByXAndY
{
	public static bool IsDivisible(int n, int x, int y) => n % x == 0 && n % y == 0;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(IsDivisible(3, 1, 3)); // true
		System.Console.WriteLine(IsDivisible(12, 2, 6)); // true
		System.Console.WriteLine(IsDivisible(100, 5, 3)); // false
	}
}