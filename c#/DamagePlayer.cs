// return health of player

public class DamagePlayer
{
	public static float Combat(float health, float damage)
	{
		float NewHealth = health - damage;
		return NewHealth < 0 ? 0 : NewHealth;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Combat(20, 9)); //11
	}
}