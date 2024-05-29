// return what drink based on age input

public class DrinkWhatWithAge
{
	public static string PeopleWithAgeDrink(int age)
	{
		if (age < 14) return "drink toddy";
		if (age < 18) return "drink coke";
		if (age < 21) return "drink beer";
		return "drink whisky";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(PeopleWithAgeDrink(19)); // drink beer
	}
}