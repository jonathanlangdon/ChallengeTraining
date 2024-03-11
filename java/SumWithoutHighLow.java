// sum numbers without single highest and single lowest values

import java.util.Arrays;

public class SumWithoutHighLow {

  public static int sum(int[] numbers) {
    if (numbers == null || numbers.length < 2)
      return 0;
    Arrays.sort(numbers);
    numbers[0] = 0;
    numbers[numbers.length - 1] = 0;
    return Arrays.stream(numbers).sum();
  }

  public static void main(String[] args) {
    System.out.println(sum(new int[] { 6, 2, 1, 8, 10, 10 })); // 26
    System.out.println(sum(new int[] { 3, 5 })); // 0
    System.out.println(sum(new int[] {})); // 0
    System.out.println(sum(null)); // 0
  }
}

/*
 * Sum all the numbers of a given array ( cq. list ), except the highest and the
 * lowest element ( by value, not by index! ).
 * 
 * The highest or lowest element respectively is a single element at each edge,
 * even if there are more than one with the same value.
 * 
 * Mind the input validation.
 * Example
 * 
 * { 6, 2, 1, 8, 10 } => 16
 * { 1, 1, 11, 2, 3 } => 6
 * 
 * Input validation
 * 
 * If an empty value ( null, None, Nothing etc. ) is given instead of an array,
 * or the given array is an empty list or a list with only 1 element, return 0.
 */