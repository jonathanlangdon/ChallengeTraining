// return area of a square created from the arc length

using System;

public class AreaOfSquareFromArcLength
{
	public class Kata
	{
		public static double SquareArea(double a)
		{
			double Radius = 2*a/Math.PI;
			return Math.Pow(Radius, 2);
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.SquareArea(2));     // expected: ~1.6211389382774046
		Console.WriteLine(Kata.SquareArea(0));     // expected: 0 
		Console.WriteLine(Kata.SquareArea(14.05)); // expected: ~80.00421981582636
	}
}
