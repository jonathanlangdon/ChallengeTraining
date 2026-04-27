// determine what Euclidean coordinate quadrant based on input coordinates

using System;
					
public class DetermineQuadrantFromCoordinates
{
	public static class Kata
	{
		public static int Quadrant(int x, int y)
		{
			if (x > 0 && y > 0) return 1;
			if (x < 0 && y > 0) return 2;
			if (x < 0 && y < 0) return 3;
			if (x > 0 && y < 0) return 4;
        	throw new ArgumentException("Not valid coordinates");
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.Quadrant(1, 2));     // expected: 1
		Console.WriteLine(Kata.Quadrant(3, 5));     // expected: 1
		Console.WriteLine(Kata.Quadrant(-10, 100)); // expected: 2
		Console.WriteLine(Kata.Quadrant(-1, -9));   // expected: 3
		Console.WriteLine(Kata.Quadrant(19, -56));  // expected: 4
		Console.WriteLine(Kata.Quadrant(1, 1));     // expected: 1
		Console.WriteLine(Kata.Quadrant(-60, -12)); // expected: 3
	}
}
