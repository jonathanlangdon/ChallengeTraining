// correct character recognition software

public class CorrectCharacterRecognitionMistakes
{
	public static string Correct(string str)
	{
		return str.Replace("5", "S").Replace("1", "I").Replace("0", "O");
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Correct("5o 1t 0nly 0n")); // So It Only On
	}
}