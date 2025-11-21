// create a template literal obj + are + feature

using System;
					
public class Program
{
	
	  public static string TempleStrings(string obj, string feature)
	  {
		  return $"{obj} are {feature}";
	  }
	
	public static void Main()
	{
		Console.WriteLine(TempleStrings("Animals", "Good")); // expected output: Animals are Good
	}
}
