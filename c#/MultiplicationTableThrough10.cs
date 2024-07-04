// return a multiplication table for a number (times 1-10)

public class MultiplicationTableThrough10
{
	public static string MultiTable(int num)
	{
		string MultiTableString = "";
		for (int i = 1; i <= 10; i++)
		{
			MultiTableString += $"{i} * {num} = {i * num}\n";
		}
		return MultiTableString.Trim();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(MultiTable(3)); // "1 * 3 = 3\n2 * 3 = 6 ... "
	}
}