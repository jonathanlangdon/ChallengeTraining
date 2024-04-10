// return true if better than average, false if not

using System;
using System.Linq;

public class BetterThanAverageArray
{

	public static bool BetterThanAverage(int[] classPoints, int yourPoints)
	{
		return yourPoints > classPoints.Average();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(BetterThanAverage(new int[] {4, 5, 6}, 6)); // True
	}
}