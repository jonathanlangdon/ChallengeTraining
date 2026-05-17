// determine the suit of a card

using System;
using System.Collections.Generic;

public class DetermineSuitOfCard
{

	public partial class Kata
	{
		private static Dictionary<char, string> suit = new Dictionary<char, string>()
		{
			{'♣', "clubs"},
			{'♠', "spades"},
			{'♥', "hearts"},
			{'♦', "diamonds"}		
		};

			public static string DefineSuit(string card)
		{
			return suit[card[^1]];
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.DefineSuit("3♣")); // expected: clubs
		Console.WriteLine(Kata.DefineSuit("12♣")); // expected: clubs
		Console.WriteLine(Kata.DefineSuit("Q♠")); // expected: spades
		Console.WriteLine(Kata.DefineSuit("9♠")); // expected: spades
		Console.WriteLine(Kata.DefineSuit("10♠")); // expected: spades
		Console.WriteLine(Kata.DefineSuit("9♦")); // expected: diamonds
		Console.WriteLine(Kata.DefineSuit("J♥")); // expected: hearts
	}
}