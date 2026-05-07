// return 1st letter of 3 inputs, then triple it

public class TripleTrouble
{
	public class Kata
	{
		public static string TripleTrouble(string one, string two, string three)
		{
			string stringBuilder = "";
			for (int i = 0; i < one.Length; i++) {
				stringBuilder += $"{one[i]}{two[i]}{three[i]}";
			}
			return stringBuilder;
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.TripleTrouble("this","test","lock")); // expected: ttlheoiscstk
		Console.WriteLine(Kata.TripleTrouble("aa","bb","cc"));       // expected: abcabc
		Console.WriteLine(Kata.TripleTrouble("Bm","aa","tn"));       // expected: Batman
		Console.WriteLine(Kata.TripleTrouble("LLh","euo","xtr"));    // expected: LexLuthor
	}
}