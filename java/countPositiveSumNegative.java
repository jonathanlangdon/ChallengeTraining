// return array with count of positives and sum of negatives

import java.util.Arrays;

public class countPositiveSumNegative {
  public static int[] countPositivesSumNegatives(int[] input) {
    if (input == null || input.length == 0)
      return new int[] {};
    int countPos = Arrays.stream(input).reduce(0, (acc, cur) -> cur > 0 ? acc + 1 : acc);
    int sumNeg = Arrays.stream(input).reduce(0, (acc, cur) -> cur < 0 ? acc + cur : acc);
    return new int[] { countPos, sumNeg };
  }

  public static void main(String[] args) {
    System.out.println(Arrays
        .toString(countPositivesSumNegatives(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }))); // {10,
                                                                                                                      // -65}
    System.out.println(Arrays.toString(countPositivesSumNegatives(new int[] {}))); // returns {}
    System.out.println(Arrays.toString(countPositivesSumNegatives(null))); // returns {}

  }
}

/*
 * Given an array of integers.
 * 
 * Return an array, where the first element is the count of positives numbers
 * and the second element is sum of negative numbers. 0 is neither positive nor
 * negative.
 * 
 * If the input is an empty array or is null, return an empty array.
 * Example
 * 
 * For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you
 * should return [10, -65].
 * 
 * 
 */