// return the value multiplied by 50 + 6

public class SuperEasyFiftySix
{
	public static string Problem(string value)
	{
		try
		{
			return (double.Parse(value) * 50 + 6).ToString();
		}
		catch
		{
			return "Error";
		}
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Problem("2")); // 106
		System.Console.WriteLine(Problem("0")); // 6
		System.Console.WriteLine(Problem("five")); // "Error"
	}
}