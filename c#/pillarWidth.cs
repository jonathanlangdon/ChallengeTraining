// Determine the distance between pillars

using System;
					
public class Program
{
	public static class Kata
	{
	 public static int Pillars(int numPill, int dist, int width)
	  {
		if(numPill < 2) return 0;
		return (numPill - 2) * width + (numPill - 1) * dist * 100;
	  } 
	}
	
	public static void Main()
	{
			// Test 1
            Console.WriteLine("Testing for number of pillars: 1, distance: 10 m and width: 10 cm");
            Console.WriteLine($"Expected: 0 | Actual: {Kata.Pillars(1, 10, 10)}");
            Console.WriteLine(new string('-', 30));

            // Test 2
            Console.WriteLine("Testing for number of pillars: 2, distance: 20 m and width: 25 cm");
            Console.WriteLine($"Expected: 2000 | Actual: {Kata.Pillars(2, 20, 25)}");
            Console.WriteLine(new string('-', 30));

            // Test 3
            Console.WriteLine("Testing for number of pillars: 11, distance: 15 m and width: 30 cm");
            Console.WriteLine($"Expected: 15270 | Actual: {Kata.Pillars(11, 15, 30)}");
            Console.WriteLine(new string('-', 30));
	}
}
