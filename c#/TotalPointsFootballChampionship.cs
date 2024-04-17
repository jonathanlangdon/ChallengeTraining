// calculate football championship points

public class TotalPointsFootballChampionship
{
	public static int TotalPoints(string[] games)
	{
		int Points = 0;
		foreach (string game in games)
		{
			int OurPoints = (int) game[0];
			int TheirPoints = (int) game[2];
			if (OurPoints > TheirPoints)
			{
				Points += 3;
			} else if (OurPoints == TheirPoints)
			{
				Points += 1;
			}
		}
		return Points;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }));
		// 30
	}
}