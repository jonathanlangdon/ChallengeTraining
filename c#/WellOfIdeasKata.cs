// return Fail, Publish or I smell a series based on how many 'good'

using System.Linq;

public class WellOfIdeasKata
{
	public static string Well(string[] ideas)
	{
		int ideaCount = ideas.Count(x => x == "good");
		if (ideaCount > 2) return "I smell a series!";
		if (ideaCount > 0) return "Publish!";
		return "Fail!";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Well(new string[] {"bad", "bad"})); // Fail!
		System.Console.WriteLine(Well(new string[] {"good", "bad", "good"})); // Publish!
		System.Console.WriteLine(Well(new string[] {"bad", "good"})); // Publish!
		System.Console.WriteLine(Well(new string[] {"bad", "good", "good", "bad", "good"})); // I smell a series!
	}
}