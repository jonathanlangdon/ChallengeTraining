// determine sex based on chromosomes

public class GenderFromChromosomes
{
	public static string ChromosomeCheck(string sperm)
	{
		return $"Congratulations! You're going to have a {(sperm[1] == 'Y' ? "son" : "duaghter")}.";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ChromosomeCheck("XY")); // son
	}
}