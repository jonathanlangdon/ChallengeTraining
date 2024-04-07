// determine love based on even or odd input

using System;

public class OppositesAttractPetals
{

	public static bool lovefunc(int flower1, int flower2)
	{
		return (flower1 + flower2) % 2 == 1;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(lovefunc(13, 2)); // true
		Console.WriteLine(lovefunc(12, 3)); // true
		Console.WriteLine(lovefunc(11, 3)); // false
		Console.WriteLine(lovefunc(12, 4)); // false
	}
}