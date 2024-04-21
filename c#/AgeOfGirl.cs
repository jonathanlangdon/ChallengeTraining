// return age of a girl based on age input

using System.Linq;

public class AgeOfGirl
{	
	public static int GetAge(string inputString) => inputString.First() - '0';

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetAge("3 years old")); // 3
	}
}