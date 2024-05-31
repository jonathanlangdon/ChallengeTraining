// take a number and return ASCII char

public class GetCharacterFromASCII
{
	public static char GetChar(int charcode)
	{
		return (char) charcode;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetChar(65)); // A
	}
}