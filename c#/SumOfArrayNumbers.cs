// return sum of numbers in an array

using System;
using System.Linq;

public class SumOfArrayNumbers
{

	public static double SumArray(double[] array) => array.Sum();

	public static void Main(string[] args)
	{
		Console.WriteLine(SumArray(new double[] {1, 5.2, 4, 0, -1})); // 9.2
		Console.WriteLine(SumArray(new double[] {})); // 0
		Console.WriteLine(SumArray(new double[] {-2.398})); // -2.398
	}
}