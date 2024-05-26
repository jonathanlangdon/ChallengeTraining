// return custome welcome based on language

using System.Collections.Generic;
using System.Linq;

public class WelcomeInOtherLanguages
{
	public static string Greet(string language)
	{
		var greetingsDictionary = new Dictionary<string, string>
        {
            { "english", "Welcome" },
            { "czech", "Vitejte" },
            { "danish", "Velkomst" },
            { "dutch", "Welkom" },
            { "estonian", "Tere tulemast" },
            { "finnish", "Tervetuloa" },
            { "flemish", "Welgekomen" },
            { "french", "Bienvenue" },
            { "german", "Willkommen" },
            { "irish", "Failte" },
            { "italian", "Benvenuto" },
            { "latvian", "Gaidits" },
            { "lithuanian", "Laukiamas" },
            { "polish", "Witamy" },
            { "spanish", "Bienvenido" },
            { "swedish", "Valkommen" },
            { "welsh", "Croeso" }
        };

		if (greetingsDictionary.ContainsKey(language)) {
			return greetingsDictionary[language];
		}
		else return "Welcome";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Greet("flemish")); // "Welgekomen"
		System.Console.WriteLine(Greet("flem3ish")); // "Welgekomen"
	}
}