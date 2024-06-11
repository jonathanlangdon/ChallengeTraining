// fizzBuzz challenge using a recursive function

public class FizzBuzzRecursive
{
	public static void FizzBuzz(int num)
	{
		if (num > 100) return;
		string result = "";
		if (num % 3 == 0) result += "Fizz";
    if (num % 5 == 0) result += "Buzz";
    if (result == "") result = $"{num}";
    System.Console.WriteLine(result);
    FizzBuzz(num + 1);
	}

	public static void Main(string[] args)
	{
		FizzBuzz(1);
	}
}