/* Given a non-empty array of integers, return the result of multiplying the values together in order. Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24 */

import java.util.Arrays;

public class reduceButGrow {
  public static int grow(int[] x) {
    return Arrays.stream(x).reduce(1, (acc, cur) -> acc * cur);
  }

  public static void main(String[] args) {
    System.out.println(grow(new int[] { 1, 2, 3 })); // 6

  }
}
