// flower i love you i love you not


public class FlowerILoveYouNot
{
	public static string HowMuchILoveYou(int numPetals)
	{
		var petalArray = new string[] 
		{
			"I love you", "a little", "a lot", "passionately", "madly", "not at all"
		};

		return petalArray[(numPetals - 1) % 6];
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(HowMuchILoveYou(4)); // "Passionately"
		System.Console.WriteLine(HowMuchILoveYou(6)); // "not at all"
		System.Console.WriteLine(HowMuchILoveYou(7)); // "I love you"
	}
}