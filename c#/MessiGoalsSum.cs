// sum up all of Messi's goals in 3 games

public class MessiGoalsSum
{

    public static int la_liga_goals = 43;
    public static int champions_league_goals = 10;
    public static int copa_del_rey_goals = 5;
    public static int total_goals = la_liga_goals + champions_league_goals + copa_del_rey_goals;


	public static void Main(string[] args)
	{
		System.Console.WriteLine(total_goals);
	}
}