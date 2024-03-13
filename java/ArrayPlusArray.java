// return sum of 2 arrays

import java.util.Arrays;

public class ArrayPlusArray {

  public static int arrayPlusArray(int[] arr1, int[] arr2) {
    int sum1 = Arrays.stream(arr1).reduce(0, (acc, cur) -> acc + cur);
    int sum2 = Arrays.stream(arr2).reduce(0, (acc, cur) -> acc + cur);
    return sum1 + sum2;
  }

  public static void main(String[] args) {
    System.out.println(arrayPlusArray(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 })); // 18
  }
}

/*
 * I'm new to coding and now I want to get the sum of two arrays... Actually the
 * sum of all their elements. I'll appreciate for your help.
 * 
 * P.S. Each array includes only integer numbers. Output is a number too.
 * 
 */