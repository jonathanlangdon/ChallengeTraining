// return average of all values in an array

using System;
using System.Linq;

public class CalculateAverageFromArray
{

	public static double FindAverage(double[] array) => array.Length == 0 ? 0 : array.Average();

	public static void Main(string[] args)
	{
		Console.WriteLine(FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 })); // 15.38
		Console.WriteLine(FindAverage(new double[] {})); // 0
	}
}