import java.util.Arrays;

public class ReverseArrayDigits {
  public static int[] digitize(long n) {
    String numString = n + "";
    int stringLength = numString.length();
    int[] intArray = new int[stringLength];
    for (int i = stringLength - 1; i >= 0; i--) {
      intArray[stringLength - 1 - i] = Character.getNumericValue(numString.charAt(i));
    }
    return intArray;
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(digitize(35231))); // [1, 3, 2, 5, 3]
  }
}

/*
 * better method
 * 
 * public class Kata {
 * public static int[] digitize(long n) {
 * return new StringBuilder().append(n)
 * .reverse()
 * .chars()
 * .map(Character::getNumericValue)
 * .toArray();
 * }
 * }
 */