// change mouth size based on if talking to alligator or not

public class MouthSizeFrog
{
	public static string MouthSize(string animal)
	{
		return animal.ToLower() == "alligator" ? "small" : "wide";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(MouthSize("toucan")); // wide
		System.Console.WriteLine(MouthSize("alligator")); // small
		System.Console.WriteLine(MouthSize("alliGator")); // small
	}
}