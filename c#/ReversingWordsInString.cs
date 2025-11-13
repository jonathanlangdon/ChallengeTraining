// put words in string in reverse order

using System;
using System.Linq;

public class Program
{
  public static string Reverse(string text)
  {
    var ReversedArray = text.Split(" ").Reverse();
	return string.Join(" ", ReversedArray);
  }
	
	
	public static void Main()
	{
      Console.WriteLine(Reverse("Hello World")); //, Is.EqualTo("World Hello"));
      Console.WriteLine(Reverse("Hi There.")); //, Is.EqualTo("There. Hi"))
      Console.WriteLine(Reverse("I am an expert at this")); //, Is.EqualTo("this at expert an am I"))
	}
}
