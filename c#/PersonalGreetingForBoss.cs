// personalized greeting based on if owner

public class PersonalGreetingForBoss
{
	public static string Greet(string name, string owner)
	{
		return $"Hello {(name == owner ? "boss" : "guest")}";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Greet("Fred", "Fred")); // Hello boss
		System.Console.WriteLine(Greet("Fred", "Joe")); // Hello guest
	}
}