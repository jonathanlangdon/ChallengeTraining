// convert all input integers to make them all negative

using System;


public class ReturnNegative
{

	public static int MakeNegative(int num)
	{
		return num > 0 ? -num : num;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(MakeNegative(3)); // -3
		Console.WriteLine(MakeNegative(-3)); // -3
	}
}
