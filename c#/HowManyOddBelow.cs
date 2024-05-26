// return how many odd numbers are below an input integer

public class HowManyOddBelow
{
	public static ulong OddCount(ulong n)
	{
		return n / 2;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(OddCount(7)); // 3 ([1, 3, 5])
		System.Console.WriteLine(OddCount(15)); // 7
		System.Console.WriteLine(OddCount(16)); // 8
	}
}

// longer method
// return n % 2 == 0 ? n / 2 : (n - 1) / 2;