// determine if a pair of characters are matching case

using System;
					
public class Program
{
	public class Kata 
	{
		public static int SameCase(char a, char b) 
		{
			if (!char.IsLetter(a) || !char.IsLetter(b)) return -1;
			bool isSame = char.IsUpper(a) == char.IsUpper(b);
			return isSame ? 1 : 0;
		}
	}
	
	
	public static void Main()
	{
            // TrueTests (expect 1) 
			Console.WriteLine("Expect 1 below");
            Console.WriteLine(Kata.SameCase('a', 'u'));
            Console.WriteLine(Kata.SameCase('A', 'U'));
            Console.WriteLine(Kata.SameCase('Q', 'P'));
            Console.WriteLine(Kata.SameCase('w', 'y'));
            Console.WriteLine(Kata.SameCase('c', 'm'));
            Console.WriteLine(Kata.SameCase('N', 'W'));

            // FalseTests (expect 0)
			Console.WriteLine("Expect 0 below");
            Console.WriteLine(Kata.SameCase('a', 'U'));
            Console.WriteLine(Kata.SameCase('A', 'u'));
            Console.WriteLine(Kata.SameCase('Q', 'p'));
            Console.WriteLine(Kata.SameCase('w', 'Y'));
            Console.WriteLine(Kata.SameCase('c', 'M'));
            Console.WriteLine(Kata.SameCase('N', 'w'));

            // NotLetters (expect -1)
			Console.WriteLine("Expect -1 below");
            Console.WriteLine(Kata.SameCase('a', '*'));
            Console.WriteLine(Kata.SameCase('A', '%'));
            Console.WriteLine(Kata.SameCase('Q', '1'));
            Console.WriteLine(Kata.SameCase('w', '-'));
            Console.WriteLine(Kata.SameCase('c', '8'));
            Console.WriteLine(Kata.SameCase('N', ':'));
	}
}
