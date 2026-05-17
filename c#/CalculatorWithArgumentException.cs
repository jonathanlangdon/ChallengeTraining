// return operations based on input with check for argument exception

using System;

public class CalculatorWithArgumentException
{
	public class Kata
	{
		public static double Calculator(double a, double b, char op)
		{
			char[] expectedOperators = new char[] {'+', '-', '*', '/'};
			if (op == expectedOperators[0]) return a + b;
			if (op == expectedOperators[1]) return a - b;
			if (op == expectedOperators[2]) return a * b;
			if (op == expectedOperators[3]) return a / b;
			throw new ArgumentException("Not valid operator");
		}
	}	

	public static void Main()
	{
		Console.WriteLine(Kata.Calculator(6, 2, '+')); // expected: 8
		Console.WriteLine(Kata.Calculator(4, 3, '-')); // expected: 1
		Console.WriteLine(Kata.Calculator(5, 5, '*')); // expected: 25
		Console.WriteLine(Kata.Calculator(5, 4, '/')); // expected: 1.25
		Console.WriteLine(Kata.Calculator(6, 2, '&')); // expected: ArgumentException
	}
}