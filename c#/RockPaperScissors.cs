// return winner of rock paper scissor

public class RockPaperScissors
{
	public static string Rps(string p1, string p2)
	{
		if (p1 == p2) return "Draw!";
		else if (
			(p1 == "rock" && p2 == "scissors")
			|| (p1 == "scissors" && p2 == "paper")
			|| (p1 == "paper" && p2 == "rock")
		) return "Player 1 won!";
		else return "Player 2 won!";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Rps("paper", "rock")); // "Player 1 won!"
		System.Console.WriteLine(Rps("scissors", "rock")); // "Player 2 won!"
		System.Console.WriteLine(Rps("rock", "rock")); // "Draw!"
	}
}

// awesome solution:
//     return p1 == p2 ? "Draw!" : $"Player {(new[] {3, -1, -2}.Contains(p1[0] - p2[0]) ? 1 : 2)} won!";