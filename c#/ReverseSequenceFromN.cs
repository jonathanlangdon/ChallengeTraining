// return an array from n down to 1

using System.Linq;

public class ReverseSequenceFromN
{
	public static int[] ReverseSeq(int n)
	{
		return Enumerable.Range(1, n).Reverse().ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", ReverseSeq(3))); // [3, 2, 1]
	}
}

/* using loop

		var newArr = new int[n];
		for (int i = n; i > 0; i--)
		{
			newArr[n - i] = i;
		}
		return newArr;
*/