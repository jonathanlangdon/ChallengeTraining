// multiply be 8 if even, by 9 if odd

using System;

public class Multiply8Even9Odd
{

	public static int Multiply(int x) => x % 2 == 0 ? x * 8 : x * 9;

	public static void Main(string[] args)
	{
		Console.WriteLine(Multiply(3)); // 27
		Console.WriteLine(Multiply(4)); // 32
	}
}