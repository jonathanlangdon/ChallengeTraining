// calculate time for sakura petal to fall from branch to ground

using System;

public class TimeForSakuraPetalFall
{

public static class Kata
{
    public static double SakuraFall(double velocity)
    {
      int branchDist = 400;
      if (velocity <= 0) return 0;
      return branchDist / velocity;
    }
}

	public static void Main()
	{
		Console.WriteLine(Kata.SakuraFall(5)); // expected: 80
	}
}