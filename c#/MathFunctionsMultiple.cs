// setup functions for different math operators

using System;
					
public class Program
{
	public static class Kata
	{
		public static int Add(int a, int b) => a + b;
		public static int Divide(int a, int b) => a / b;		
		public static int Multiply(int a, int b) => a * b;
		public static int Mod(int a, int b) => a % b;
		public static int Exponent(int a, int b) => (int)Math.Pow(a, b);
		public static int Subt(int a, int b) => a - b;

	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.Add(5, 7));        // expected: 12
		Console.WriteLine(Kata.Multiply(5, 2));   // expected: 10

		// additional operations
		Console.WriteLine(Kata.Divide(10, 2));    // expected: 5
		Console.WriteLine(Kata.Mod(10, 3));       // expected: 1
		Console.WriteLine(Kata.Exponent(2, 3));   // expected: 8
		Console.WriteLine(Kata.Subt(10, 4));      // expected: 6

		// edge cases
		Console.WriteLine(Kata.Divide(5, 1));     // expected: 5
		Console.WriteLine(Kata.Mod(5, 5));        // expected: 0
		Console.WriteLine(Kata.Exponent(2, 0));   // expected: 1
		Console.WriteLine(Kata.Subt(0, 5));       // expected: -5
	}
}
