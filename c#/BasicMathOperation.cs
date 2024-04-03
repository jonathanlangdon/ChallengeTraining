// given an operator input, calculate an operation

using System;
using System.Data;

public class BasicMathOperation
{

	public static double basicOp(char operation, double value1, double value2)
	{
		return Convert.ToDouble(new DataTable().Compute($"{value1} {operation} {value2}", ""));
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(basicOp('*', 5, 5)); // 25
		Console.WriteLine(basicOp('+', 5, 5)); // 10
	}
}