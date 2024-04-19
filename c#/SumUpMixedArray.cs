// given an array of a mix of strings and numbers, sum up all values

using static System.Convert;
using System.Linq;

public class SumUpMixedArray
{
	public static int SumMix(object[] x) => x.Sum(ToInt32);

	public static void Main(string[] args)
	{
		System.Console.WriteLine(SumMix(new object[] {9, 3, "7", "3"})); // 22
	}
}