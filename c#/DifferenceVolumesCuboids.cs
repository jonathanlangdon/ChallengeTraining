// find difference of volumes of 2 cuboids

using System;
using System.Linq;

public class DifferenceVolumesCuboids
{
	public static int FindDifference(int[] a, int[] b)
	{
		return Math.Abs(a.Aggregate(1, (a,c) => a * c) - b.Aggregate(1, (a,c) => a * c));
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(FindDifference(new int[] {2,2,3},new int[] {5,4,1})); // 12
	}
}