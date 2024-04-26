// remove every other element in an array (every 2nd)

using System.Linq;

public class RemovingEveryOtherElement
{
	public static object[] RemoveEveryOther(object[] arr)
	{
		return arr.Where((item, index) => index % 2 == 0).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })));
		// [1, 3, 5, 7, 9]
	}
}