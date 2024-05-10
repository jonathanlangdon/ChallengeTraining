// return maximum possible between possible combinations of operations

using System;
using System.Linq;

public class MaxNumberWithExpressions
{
	public static int ExpressionsMatter(int a, int b, int c)
	{
		int exp1 = a + b + c;
		int exp2 = a * b * c;
		int exp3 = a + b * c;
		int exp4 = a * b + c;
		int exp5 = (a + b) * c;
		int exp6 = a * (b + c);
		return (new int[] {exp1, exp2, exp3, exp4, exp5, exp6}).Max();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(ExpressionsMatter(2, 1, 2)); // 6
		Console.WriteLine(ExpressionsMatter(2, 1, 1)); // 4
		Console.WriteLine(ExpressionsMatter(1, 1, 1)); // 3
		Console.WriteLine(ExpressionsMatter(1, 2, 3)); // 9
		Console.WriteLine(ExpressionsMatter(1, 3, 1)); // 5
		Console.WriteLine(ExpressionsMatter(5, 1, 3)); // 20
		Console.WriteLine(ExpressionsMatter(1, 6, 1)); // 8
		Console.WriteLine(ExpressionsMatter(6, 7, 1)); // 48
		Console.WriteLine(ExpressionsMatter(3, 5, 7)); // 105
	}

}

