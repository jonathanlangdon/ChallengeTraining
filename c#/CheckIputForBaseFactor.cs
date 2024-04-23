// Check if an input is a factor of a base input

public class CheckInputForBaseFactor
{
	public static bool CheckForFactor(int num, int factor)
	{
		return num % factor == 0;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(CheckForFactor(63, 7)); // true
		System.Console.WriteLine(CheckForFactor(62, 7)); // false
	}
}