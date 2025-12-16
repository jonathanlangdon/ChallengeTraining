// take 2 numbers, find modulus of smaller from larger

using System;
					
public class Program
{
	
	public class Kata
	{
	  public static int Remainder(int a, int b)
	  {
		  int[] SortedArray = new int[] {a, b};
		  Array.Sort(SortedArray);
		  if (SortedArray[0] == 0) throw new DivideByZeroException();
		  return SortedArray[1] % SortedArray[0];
	  }
	}

	public static void Main()
	{
		Console.WriteLine("--- Kata.Remainder Test Output ---");

        // Test 1: Standard math check
        // Assert.That(Kata.Remainder(17, 5), Is.EqualTo(2))
        Console.WriteLine($"Remainder(17, 5): {Kata.Remainder(17, 5)} (Expected: 2)");

        // Test 2: Argument order check
        // Assert.That(Kata.Remainder(72, 13), Is.EqualTo(Kata.Remainder(13, 72)))
        int res1 = Kata.Remainder(72, 13);
        int res2 = Kata.Remainder(13, 72);
        Console.WriteLine($"Results match: {res1 == res2}");

        // Test 3: Division by zero (0, 1)
        // Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 1))
        try {
            Console.Write("Remainder(0, 1): ");
            Console.WriteLine(Kata.Remainder(0, 1));
        } catch (DivideByZeroException) {
            Console.WriteLine("Threw DivideByZeroException (Expected)");
        } catch (Exception e) {
            Console.WriteLine($"Threw wrong exception: {e.GetType().Name}");
        }

        // Test 4: Division by zero (0, 0)
        // Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 0))
        try {
            Console.Write("Remainder(0, 0): ");
            Console.WriteLine(Kata.Remainder(0, 0));
        } catch (DivideByZeroException) {
            Console.WriteLine("Threw DivideByZeroException (Expected)");
        } catch (Exception e) {
            Console.WriteLine($"Threw wrong exception: {e.GetType().Name}");
        }
	}
}
