// take int array and output each item as square or square-root depending on if has an integer square root

using System.Linq;

public class ToSquareRootOrNot
{
	public static int[] SquareOrSquareRoot(int[] numArr)
	{
		return numArr.Select(x => 
		{
			int SquareRoot = (int)System.Math.Sqrt(x);
			return SquareRoot * SquareRoot == x ? SquareRoot : x * x;
		}).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", SquareOrSquareRoot(new int[] {4, 3, 9, 7, 2, 1}))); // 2, 9, 3, 49, 4, 1
	}
}