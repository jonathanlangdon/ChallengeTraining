// turn digits into 1's or 0's based on comparison to 5

import java.util.Arrays;

public class FakeBinary {
  public static String fakeBin(String numberString) {
    int[] intArray = numberString.chars()
        .map(c -> c - '0')
        .toArray();
    String[] bitArray = Arrays.stream(intArray)
        .mapToObj(n -> n >= 5 ? "1" : "0")
        .toArray(String[]::new);
    return String.join("", bitArray);
  }

  public static void main(String[] args) {
    System.out.println(fakeBin("50932196")); // "10100011"
  }
}

/*
 * Given a string of digits, you should replace any digit below 5 with '0' and
 * any digit 5 and above with '1'. Return the resulting string.
 * 
 * Note: input will never be an empty string
 * 
 */

// better method:
// return numberString.replaceAll("[0-4]", "0").replaceAll("[5-9]", "1");