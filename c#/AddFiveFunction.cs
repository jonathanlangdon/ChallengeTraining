// fix a function that returns the wrong number

public class AddFiveFunction
{
	public static int AddFive(int num) => num + 5;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(AddFive(4)); // 9
	}
}