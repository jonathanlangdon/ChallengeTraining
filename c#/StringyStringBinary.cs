// return a string of 1's and 0's based on input integer

public class StringyStringBinary
{
	public static string Stringy(int size)
	{
		string NewString = "";
		for (int i = 0; i < size; i++)
		{
			NewString += (i % 2 == 0 ? "1" : "0");
		}
		return NewString;
	}

	public static void Main()
	{
		System.Console.WriteLine(Stringy(3)); // 101
	}
}