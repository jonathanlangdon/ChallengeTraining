// output different boasts depending on winner (case-insensitive)

using System;
					
public class Program
{
	
	public static class Kata
	{
	  public static string Quote(string fighter)
	  {
		string FighterLowerCase = fighter.ToLower();
		if(FighterLowerCase == "george saint pierre")
			return "I am not impressed by your performance.";
		else if(FighterLowerCase == "conor mcgregor")
			return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
		return "Please enter a valid fighter";
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine("--- Kata.Quote() Output ---");

        // Assert.That(Kata.Quote("george saint pierre"), Is.EqualTo("I am not impressed by your performance."));
        Console.WriteLine($"Quote(\"george saint pierre\") -> \"{Kata.Quote("george saint pierre")}\"");
        
        // Assert.That(Kata.Quote("conor mcgregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
        Console.WriteLine($"Quote(\"conor mcgregor\") -> \"{Kata.Quote("conor mcgregor")}\"");
        
        // Assert.That(Kata.Quote("George Saint Pierre"), Is.EqualTo("I am not impressed by your performance."));
        Console.WriteLine($"Quote(\"George Saint Pierre\") -> \"{Kata.Quote("George Saint Pierre")}\"");
        
        // Assert.That(Kata.Quote("Conor McGregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
        Console.WriteLine($"Quote(\"Conor McGregor\") -> \"{Kata.Quote("Conor McGregor")}\"");
	}
}
