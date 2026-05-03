// output the number times 5 to the power of how many digits it has

using System;
					
public class MultipleByFiveToPowerOfDigits
{
	public class Kata
	{
		public static int Multiply(int number)
		{
			return (int) (number * Math.Pow(5,Math.Abs(number).ToString().Length));
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.Multiply(10));   // expected: 250
		Console.WriteLine(Kata.Multiply(5));    // expected: 25
		Console.WriteLine(Kata.Multiply(200));  // expected: 25000
		Console.WriteLine(Kata.Multiply(0));    // expected: 0
		Console.WriteLine(Kata.Multiply(-2));   // expected: -10
	}
}
