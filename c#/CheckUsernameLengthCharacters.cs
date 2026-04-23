// validate username with regex

using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public class Kata
	{
		public static bool ValidateUsr(string username) 
		{
			return Regex.IsMatch(username, @"^[a-z_0-9]{4,16}$");
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.ValidateUsr("asd43 34")); // expected: False
		Console.WriteLine(Kata.ValidateUsr("a")); // expected: False
		Console.WriteLine(Kata.ValidateUsr("012")); // expected: False
		Console.WriteLine(Kata.ValidateUsr("Hass")); // expected: False
		Console.WriteLine(Kata.ValidateUsr("Hasd_12ssssssssssssssasasasasasssasassss")); // expected: False
		Console.WriteLine(Kata.ValidateUsr("")); // expected: False
		Console.WriteLine("These are True.....:");
		Console.WriteLine(Kata.ValidateUsr("____")); // expected: True
		Console.WriteLine(Kata.ValidateUsr("asddsa")); // expected: True
		Console.WriteLine(Kata.ValidateUsr("p1pp1")); // expected: True
		Console.WriteLine(Kata.ValidateUsr("asd43_34")); // expected: True
	}
}