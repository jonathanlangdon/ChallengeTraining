// determine how many cubes in a column based on right or left gravity

import java.util.Arrays;

public class gravityFlipRightLeft
{
  public static int[] flip(char dir, int[] arr) {
    if (dir == 'L') arr = Arrays.stream(arr).map(x -> -x).toArray();
    Arrays.sort(arr);
    if (dir == 'L') arr = Arrays.stream(arr).map(x -> -x).toArray();
    return arr;
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(flip('R', new int[] {3, 2, 1, 2}))); // [1, 2, 2, 3]
    System.out.println(Arrays.toString(flip('L', new int[] {1, 4, 5, 3, 5}))); // [5, 5, 4, 3, 1]
  }
}