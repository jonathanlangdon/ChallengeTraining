// return whether someone plays a banjo based on their name

using System;

public class PlayingBanjoByName
{

	public static string AreYouPlayingBanjo(string name)
	{
		if (name.ToLower()[0] == 'r')
		{
			return name + " plays banjo";
		}
		else
		{
			return name + " does not play banjo";
		}
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(AreYouPlayingBanjo("Rikke")); // Rikke plays banjo
		Console.WriteLine(AreYouPlayingBanjo("Martin")); // Martin does not play banjo
	}
}