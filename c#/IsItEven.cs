// return true/false if a number is even

public class IsItEven
{
	public static bool IsEven(double n) => n % 2 == 0;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(IsEven(4.088)); // false
		System.Console.WriteLine(IsEven(4.087)); // false
		System.Console.WriteLine(IsEven(4.00)); // true
		System.Console.WriteLine(IsEven(4)); // true
		System.Console.WriteLine(IsEven(-4)); // true
		System.Console.WriteLine(IsEven(3.00)); // false
		System.Console.WriteLine(IsEven(3)); // false
		System.Console.WriteLine(IsEven(-3)); // false
	}
}