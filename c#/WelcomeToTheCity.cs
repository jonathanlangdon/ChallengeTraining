using System;
					
public class WelcomeToTheCity
{
	
	  public static string SayHello(string[] name, string city, string state)
	  {
		string fullName = string.Join(" ", name);
		return $"Hello, {fullName}! Welcome to {city}, {state}!";
	  }
	
	
	public static void Main()
	{
		Console.WriteLine(SayHello(["Joe", "John", "Smith"], "New York", "NY")); // Hello, Joe John Smith! Welcome to New York, NY!
	}
	
}