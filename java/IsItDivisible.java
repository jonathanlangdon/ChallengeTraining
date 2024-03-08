//  check if a number is divisible by 2 ints

public class IsItDivisible {

  public static boolean isDivisible(long n, long x, long y) {
    return n % x == 0 && n % y == 0;
  }

  public static void main(String[] args) {
    System.out.println(isDivisible(12, 4, 3)); // true
    System.out.println(isDivisible(13, 4, 3)); // false
  }
}

/*
 * Create a function that checks if a number n is divisible by two numbers x AND
 * y. All inputs are positive, non-zero numbers.
 */
