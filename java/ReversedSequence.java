// build an array of integers from n to 1

import java.util.Arrays;

public class ReversedSequence {

  public static int[] reverse(int n) {
    int[] intArray = new int[n];
    for (int i = 0; i < n; i++) {
      intArray[i] = n - i;
    }
    return intArray;
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(reverse(5))); // [5,4,3,2,1]
  }
}

/*
 * Build a function that returns an array of integers from n to 1 where n>0.
 * 
 * Example : n=5 --> [5,4,3,2,1]
 * 
 */
