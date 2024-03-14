// populate an array from 1 through a given number

import java.util.Arrays;

public class CountTheMonkeys {

  public static int[] monkeyCount(final int n) {
    int[] arr = new int[n];
    for (int i = 1; i <= n; i++) {
      arr[i - 1] = i;
    }
    return arr;
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(monkeyCount(3))); // [1, 2, 3]
  }
}