// return boolean if string is all caps

public class IsStringUppercase
{
	public static bool IsUpperCase(string text)
	{
		return text == text.ToUpper();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(IsUpperCase("This")); //false
		System.Console.WriteLine(IsUpperCase("THIS")); //true
	}
}