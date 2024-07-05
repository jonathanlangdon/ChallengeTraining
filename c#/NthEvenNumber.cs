// return the nth even number

public class NthEvenNumber
{
	public static int NthEven(int n) => (n - 1) * 2;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(NthEven(1)); // 0
		System.Console.WriteLine(NthEven(3)); // 4
		System.Console.WriteLine(NthEven(100)); // 198
	}
}