// create a poorly (not clean) written function that takes a flag input

using System;

public class WriteADirtyFunction
{
	public static void If(bool condition, Action func1, Action func2)
	{
		if (condition) func1();
		else func2();
	}

	public static void Main(string[] args)
	{
		bool a = false;
		If(true, () => a = true, () => a = false);
		System.Console.WriteLine(a); // true

	}
}