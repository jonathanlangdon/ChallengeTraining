// Determine how many people you'd block if you left the theater

using System;
					
public class HowManyTheaterBlockWalkOut
{
	public class Kata
	{
		public static int SeatsInTheater(int nCols, int nRows, int col, int row)
		{
			return (nCols - (col - 1)) * (nRows - row);
		}
	}
	
	
	public static void Main()
	{
		Console.WriteLine(Kata.SeatsInTheater(16, 11, 5, 3));        // expected: 96
		Console.WriteLine(Kata.SeatsInTheater(1, 1, 1, 1));          // expected: 0
		Console.WriteLine(Kata.SeatsInTheater(13, 6, 8, 3));         // expected: 18
		Console.WriteLine(Kata.SeatsInTheater(60, 100, 60, 1));      // expected: 99
		Console.WriteLine(Kata.SeatsInTheater(1000, 1000, 1000, 1000)); // expected: 0
	}
}
