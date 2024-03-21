// return an array with input of n... where [2^0, ... up to 2^n] is returned

import java.util.Arrays;

public class PowersOf2 {

  public static long[] powersOfTwo(int n) {
    long[] newArr = new long[n + 1];
    for (int i = 0; i <= n; i++) {
      newArr[i] = (long) Math.pow(2, i);
    }
    return newArr;
  }

  public static void main(String[] args) {

    System.out.println(Arrays.toString(powersOfTwo(0))); // [1]
    System.out.println(Arrays.toString(powersOfTwo(1))); // [1, 2]
    System.out.println(Arrays.toString(powersOfTwo(4))); // [1, 2, 4, 8, 16]
  }
}

/*
 * shorter method using stream API
 * 
 * 
 * static long[] powersOfTwo(int n) {
 * return rangeClosed(0, n).map(i -> (long) Math.pow(2, i)).toArray();
 * }
 * 
 */