// if input is Zach, output 18 (lightsabers) otherwise, 0

public class LightsabersForZach
{
	public static int HowManyLightsabersDoYouOwn(string name)
	{
		return name == "Zach" ? 18 : 0;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(HowManyLightsabersDoYouOwn("Zach")); // 18
		System.Console.WriteLine(HowManyLightsabersDoYouOwn("Zacha")); // 0
	}
}