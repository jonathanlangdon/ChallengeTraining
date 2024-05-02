// find first non-consecutive number in array

public class FindFirstNonConsecutive
{
	public static object FirstNonConsecutive(int[] arr)
	{
		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i - 1] != arr[i] - 1) return arr[i];
		}
		return null;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", FirstNonConsecutive(new int[] {1, 2}))); // null
		System.Console.WriteLine(string.Join(", ", FirstNonConsecutive(new int[] {1, 2, 4}))); // 3
	}
}