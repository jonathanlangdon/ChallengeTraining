// given a side and volume, determine if it could be a cube

using System;
					
public class Program
{
	
	  public class CubeChecker
	  {
		public bool IsCube(double volume, double side)
		{
			if (volume <= 0 || side <= 0) return false;
			if (side * side * side == volume) return true;
			return false;
		}
	  }

	public static void Main()
	{
		CubeChecker cube = new CubeChecker();

        Console.WriteLine("--- Tests Expecting TRUE ---");
        // Assert.That(cube.IsCube(1, 1), Is.EqualTo(true));
        PrintTest(cube.IsCube(1, 1), true, "Vol: 1, Side: 1");
        
        // Assert.That(cube.IsCube(8, 2), Is.EqualTo(true));
        PrintTest(cube.IsCube(8, 2), true, "Vol: 8, Side: 2");

        Console.WriteLine("\n--- Tests Expecting FALSE ---");
        // Assert.That(cube.IsCube(2, 1), Is.EqualTo(false));
        PrintTest(cube.IsCube(2, 1), false, "Vol: 2, Side: 1");
        
        // Assert.That(cube.IsCube(6, 3), Is.EqualTo(false));
        PrintTest(cube.IsCube(6, 3), false, "Vol: 6, Side: 3");
        
        // Assert.That(cube.IsCube(-8, -2), Is.EqualTo(false));
        PrintTest(cube.IsCube(-8, -2), false, "Vol: -8, Side: -2");
        
        // Assert.That(cube.IsCube(0, 0), Is.EqualTo(false));
        PrintTest(cube.IsCube(0, 0), false, "Vol: 0, Side: 0");
        
        // Assert.That(cube.IsCube(200, 4), Is.EqualTo(false));
        PrintTest(cube.IsCube(200, 4), false, "Vol: 200, Side: 4");
    }

    public static void PrintTest(bool actual, bool expected, string label)
		{
			string status = (actual == expected) ? "[PASS]" : "[FAIL]";
			Console.WriteLine($"{status} {label} -> Actual: {actual}, Expected: {expected}");
		}
		
}
