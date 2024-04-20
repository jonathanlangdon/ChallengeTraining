// calculate average of an array

using System.Linq;

public class GetMeanOfAnArray
{
	public static int GetAverage(int[] marks) => (int) marks.Average();

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetAverage(new int[] {2, 3, 6})); // 3 (3.666 rounded down)
	}
}