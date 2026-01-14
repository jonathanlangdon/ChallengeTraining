// return response based on how many dalmatian puppies

using System;
using System.Collections.Generic;
					
public class Program
{
	public static class Kata
    {
        public static string HowManyDalmatians(int n)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            string Respond = ""; 
			if( n <= 10)
			{
				Respond = dogs[0];
			} 
			else if(n <= 50)
			{
				Respond = dogs[1];
			} else if(n == 101) 
			{
				Respond = dogs[3];
			}
			else
			{
				Respond = dogs[2];
			}
            return Respond;
        }
    }
	
	public static void Main()
	{
		Console.WriteLine(Kata.HowManyDalmatians(26));  // Expected: "More than a handful!"
		Console.WriteLine(Kata.HowManyDalmatians(8));   // Expected: "Hardly any"
		Console.WriteLine(Kata.HowManyDalmatians(14));  // Expected: "More than a handful!"
		Console.WriteLine(Kata.HowManyDalmatians(80));  // Expected: "Woah that's a lot of dogs!"
		Console.WriteLine(Kata.HowManyDalmatians(100)); // Expected: "Woah that's a lot of dogs!"
		Console.WriteLine(Kata.HowManyDalmatians(50));  // Expected: "More than a handful!"
		Console.WriteLine(Kata.HowManyDalmatians(10));  // Expected: "Hardly any"
		Console.WriteLine(Kata.HowManyDalmatians(101)); // Expected: "101 DALMATIONS!!!"
	}
}
