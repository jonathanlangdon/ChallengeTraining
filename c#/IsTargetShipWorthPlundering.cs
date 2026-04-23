// Determine if a target ship is worth plundering

using System;
					
public class Program
{
	public class Ship
	{
		public int Draft;
		public int Crew;

		public Ship(int draft, int crew)
		{
			Draft = draft;
			Crew = crew;
		}
		
		public bool IsWorthIt()
		{
			double CrewWeight = 1.5;
			double PlunderWorthyLimit = 20;  // more than this and it's worth it
			return (Draft - Crew * CrewWeight) > PlunderWorthyLimit;
		}

	}
	
	public static void Main()
	{
		Console.WriteLine(new Ship(15, 10).IsWorthIt());  // expected: False
		Console.WriteLine(new Ship(15, 20).IsWorthIt());  // expected: False 
		Console.WriteLine(new Ship(35, 20).IsWorthIt());  // expected: False
		Console.WriteLine(new Ship(0, 0).IsWorthIt());    // expected: False
		Console.WriteLine(new Ship(20, 2).IsWorthIt());   // expected: False (boundary: exactly 20 - crew*1.5 = 17)
		Console.WriteLine(new Ship(30, 20).IsWorthIt());  // expected: False (high crew reduces value)
		Console.WriteLine(new Ship(21, 0).IsWorthIt());   // expected: True
		Console.WriteLine(new Ship(100, 20).IsWorthIt()); // expected: True
	}
}