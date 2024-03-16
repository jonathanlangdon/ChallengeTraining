// returns an array of integers extending from an input # to another

import java.util.Arrays;
import java.util.stream.IntStream;

public class WhatIsBetween {

  public static int[] between(int a, int b) {
    return IntStream.rangeClosed(a, b).toArray();
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(between(2, 5))); // [2, 3, 4, 5]
    System.out.println(Arrays.toString(between(-2, 2))); // [-2, -1, 0, 1, 2]
  }
}