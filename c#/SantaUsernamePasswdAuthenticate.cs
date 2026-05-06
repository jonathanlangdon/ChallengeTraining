// check Santa's username and passwd

using System;

public class SantaUsernamePasswdAuthenticate
{
	public class Sleigh
	{
		public static bool Authenticate(string name, string password)
		{
			return name == "Santa Claus" && password == "Ho Ho Ho!";
		}
	}

	public static void Main()
	{
		
		Console.WriteLine(Sleigh.Authenticate("Santa Claus", "Ho Ho Ho!")); // expected: True
		Console.WriteLine(Sleigh.Authenticate("Santa", "Ho Ho Ho!"));       // expected: False
		Console.WriteLine(Sleigh.Authenticate("Santa", "Ho Ho ho!"));       // expected: False
		Console.WriteLine(Sleigh.Authenticate("Santa Claus", "Ho Ho!"));    // expected: False
		Console.WriteLine(Sleigh.Authenticate("jhoffner", "CodeWars"));     // expected: False
	}
}
