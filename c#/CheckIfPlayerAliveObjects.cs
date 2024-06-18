// function to check if player is alive

public class Player
{
  public int Health {get; set;} = 100;
  
  public Player() {}
  
  public bool CheckAlive() => this.Health > 0;
}

public class CheckIfPlayerAlive
{
	public static void Main(string[] args)
	{
		Player greg = new Player();
		greg.Health = 5;
		System.Console.WriteLine(greg.CheckAlive()); // true

		Player joe = new Player();
		joe.Health = 0;
		System.Console.WriteLine(joe.CheckAlive()); // false
	}
}