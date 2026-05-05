// Create Ghost objects with random color attribute of "white" or "yellow" or "purple" or "red" when instantiated

using System;

public class randomGhostColorInstanceClass
{

	public class Ghost
	{
		private string ghostColor;
		private static string[] Colors = new string[]{"white", "yellow", "purple", "red"};

		public Ghost()
		{
			int RandomColorIndex = Random.Shared.Next(Colors.Length);
			ghostColor = Colors[RandomColorIndex];
		}

		public string GetColor()
		{
			return ghostColor;
		}
	}

	public static void Main()
	{
		Ghost ghost1 = new Ghost();
		string color1 = ghost1.GetColor();
		Console.WriteLine(color1); // expected: one of "white", "yellow", "purple", "red"
		Console.WriteLine(ghost1.GetColor() == color1); // expected: True  
		Ghost ghost2 = new Ghost();
		string color2 = ghost2.GetColor();
		Console.WriteLine(color2); // expected: one of "white", "yellow", "purple", "red" 
		Console.WriteLine(ghost2.GetColor() == color2); // expected: True 
		Ghost ghost3 = new Ghost();
		string color3 = ghost3.GetColor();
		Console.WriteLine(color3); // expected: one of "white", "yellow", "purple", "red" 
		Console.WriteLine(ghost3.GetColor() == color3); // expected: True 
		
	}
}
