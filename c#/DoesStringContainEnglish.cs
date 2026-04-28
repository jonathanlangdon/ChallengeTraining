// determine if string has "English" in it

using System;
using System.Text.RegularExpressions;
					
public class DoesStringContainEnglish
{
	static class Kata
	{
		public static bool SpeakEnglish(string sentence)
		{
			return Regex.IsMatch(sentence, @"(?i)(english)");
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.SpeakEnglish("hello world"));                 // expected: False
		Console.WriteLine(Kata.SpeakEnglish("egnlish"));                     // expected: False
		Console.WriteLine(Kata.SpeakEnglish(""));                            // expected: False
		Console.WriteLine(Kata.SpeakEnglish("ABC123DOREME"));                // expected: False
		Console.WriteLine("The following are True:----");
		Console.WriteLine(Kata.SpeakEnglish("english"));                     // expected: True
		Console.WriteLine(Kata.SpeakEnglish("1234english ;k"));              // expected: True
		Console.WriteLine(Kata.SpeakEnglish("I speak English"));             // expected: True
		Console.WriteLine(Kata.SpeakEnglish("eNgliSh"));                     // expected: True
		Console.WriteLine(Kata.SpeakEnglish("1234#$%%eNglish ;k9"));         // expected: True
		Console.WriteLine(Kata.SpeakEnglish("spanish, english, french"));    // expected: True
		Console.WriteLine(Kata.SpeakEnglish("englishENGLISHEnGlISHENglisH")); // expected: True
		Console.WriteLine(Kata.SpeakEnglish("HeLlO tHeR3 enGLiSh MuffIN"));  // expected: True
	}
}
