// Sum all values from two arrays

using System.Linq;

public class SumOfTwoArrays
{
	public static int ArrayPlusArray(int[] arr1, int[] arr2) => arr1.Sum() + arr2.Sum();

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ArrayPlusArray(new int[]{1,2,3}, new int[]{4,5,6})); // 21
	}
}