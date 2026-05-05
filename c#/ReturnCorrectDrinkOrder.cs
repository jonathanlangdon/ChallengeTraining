// return the correct drink order

using System;
using System.Collections.Generic;
					
public class Program
{
	public class Kata
	{
		public static string GetDrinkByProfession(string p)
		{
			Dictionary<string, string> drinkMap = new Dictionary<string, string>()
			{
				{ "jabroni", "Patron Tequila" },
				{ "school counselor", "Anything with Alcohol" },
				{ "programmer", "Hipster Craft Beer" },
				{ "bike gang member", "Moonshine" },
				{ "politician", "Your tax dollars" },
				{ "rapper", "Cristal" }
			};
			
			bool validDrink = drinkMap.TryGetValue(p.ToLower(), out string drink);
			return validDrink ? drink : "Beer";
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.GetDrinkByProfession("jabrOni"));           // expected: Patron Tequila
		Console.WriteLine(Kata.GetDrinkByProfession("scHOOl counselor")); // expected: Anything with Alcohol 
		Console.WriteLine(Kata.GetDrinkByProfession("prOgramMer"));       // expected: Hipster Craft Beer
		Console.WriteLine(Kata.GetDrinkByProfession("bike ganG member")); // expected: Moonshine
		Console.WriteLine(Kata.GetDrinkByProfession("poLiTiCian"));       // expected: Your tax dollars
		Console.WriteLine(Kata.GetDrinkByProfession("rapper"));           // expected: Cristal
		Console.WriteLine(Kata.GetDrinkByProfession("pundit"));           // expected: Beer
		Console.WriteLine(Kata.GetDrinkByProfession("Pug"));              // expected: Beer
	}
}