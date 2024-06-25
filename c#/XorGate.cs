// create a function that acts like a xor gate

public class XorGate
{
	public static bool Xor(bool a, bool b)
	{
		return a != b;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Xor(false, false)); // false
		System.Console.WriteLine(Xor(true, false)); // true
		System.Console.WriteLine(Xor(true, true)); // false
	}
}

// another solution:

// return a ^ b;
// OR
// return a && b ? false : a || b ? true : false;