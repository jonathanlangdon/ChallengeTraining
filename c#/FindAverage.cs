// given an enumerable, find average and output an int

using System;
using System.Linq;
					
public class Program
{
	public class GrassHopper 
    {
        public static int FindAverage(int[] nums)
        {
            return (int)nums.Average();
        }
    }
	
	
	public static void Main()
	{
		// First Test: Assert.That(GrassHopper.FindAverage(new[] { 1 }), Is.EqualTo(1));
        Console.WriteLine(GrassHopper.FindAverage(new[] { 1 })); // Expected: 1

        // Second Test: Assert.That(GrassHopper.FindAverage(new[] { 1, 3, 5, 7 }), Is.EqualTo(4));
        Console.WriteLine(GrassHopper.FindAverage(new[] { 1, 3, 5, 7 })); // Expected: 4

        // Third Test: Assert.That(GrassHopper.FindAverage(new[] { -10, -5, -5, 0 }), Is.EqualTo(-5));
        Console.WriteLine(GrassHopper.FindAverage(new[] { -10, -5, -5, 0 })); // Expected: -5

        // Fourth Test: Assert.That(GrassHopper.FindAverage(new[] { 0 }), Is.EqualTo(0));
        Console.WriteLine(GrassHopper.FindAverage(new[] { 0 })); // Expected: 0
	}
}
