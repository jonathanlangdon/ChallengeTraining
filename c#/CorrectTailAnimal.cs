// fix function that determines if tail fits on animal

using System;
					
public class Program
{
	public class Kata
	{
	  public static bool CorrectTail(string body, string tail)
	  {
		string sub = body.Substring(body.Length - tail.Length);

		return sub == tail;
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.CorrectTail("Fox", "x"));      // True 
        Console.WriteLine(Kata.CorrectTail("Rhino", "o"));    // True 
        Console.WriteLine(Kata.CorrectTail("Meerkat", "t"));  // True
        Console.WriteLine(Kata.CorrectTail("Emu", "t"));      // False
        Console.WriteLine(Kata.CorrectTail("Badger", "s"));   // False
        Console.WriteLine(Kata.CorrectTail("Giraffe", "d"));  // False
	}
}
