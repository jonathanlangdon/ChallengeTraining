// remove trailing zeros

public class NoZerosHeroes
{
	public static int NoBoringZeros(int n)
	{
		if (n % 10 != 0 || n == 0) return n;
		return NoBoringZeros(n / 10);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(NoBoringZeros(10500)); //105
		System.Console.WriteLine(NoBoringZeros(105)); //105
		System.Console.WriteLine(NoBoringZeros(-10500)); //-105
		System.Console.WriteLine(NoBoringZeros(0)); //-105
	}
}