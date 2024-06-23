// determine if an input is plural (not singular)

public class IsItPlural
{
	public static bool Plural(double n) => n != 1;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Plural(0.5)); // true
		System.Console.WriteLine(Plural(1)); // false
		System.Console.WriteLine(Plural(100)); // true
		System.Console.WriteLine(Plural(0)); // true
	}
}