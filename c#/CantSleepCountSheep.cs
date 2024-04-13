// count sheep from 1 to n

using System.Linq;

public class CantSleepCountSheep
{
	public static string CountSheep(int n)
	{
		return string.Concat(Enumerable.Range(1, n).Select(x => $"{x} sheep..."));
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(CountSheep(2)); // "1 sheep...2 sheep..." 
	}
}