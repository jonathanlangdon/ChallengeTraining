// Fizz Buzz May 2024

public class FizzBuzzMay2024
{
	public static void fizzbuzz()
	{
		for (int i = 1; i <= 100; i++)
		{
			bool MultipleOf5 = i % 5 == 0;
			bool MultipleOf3 = i % 3 == 0;
			string output = "";
			if (MultipleOf3 && MultipleOf5) {
				output = "FizzBuzz";
			} else if (MultipleOf3) {
				output = "Fizz";
			} else if (MultipleOf5) {
				output = "Buzz";
			} else {
				output = i.ToString();
			}
			System.Console.WriteLine(output);
		}
	}

	public static void Main(string[] args)
	{
		fizzbuzz();
	}
}