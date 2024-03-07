// use either min or max method to return max or min

import java.util.Arrays;

public class findMaxOrMin {

  public static int min(int[] numArray) {
    return Arrays.stream(numArray).min().orElse(0);
  }

  public static int max(int[] numArray) {
    return Arrays.stream(numArray).max().orElse(0);
  }

  public static void main(String[] args) {
    System.out.println(min(new int[] { -52, 56, 30, 29, -54, 0, -110 })); // -110
    System.out.println(max(new int[] { -52, 56, 30, 29, -54, 0, -110 })); // 56
    System.out.println(min(new int[] { 5 })); // 5
    System.out.println(max(new int[] { 5 })); // 5
  }
}

/*
 * Your task is to make two functions ( max and min, or maximum and minimum,
 * etc., depending on the language ) that receive a list of integers as input,
 * and return the largest and lowest number in that list, respectively.
 */