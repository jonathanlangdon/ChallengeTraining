// return new array with inversed values

import java.util.Arrays;

public class invertValues {
  public static int[] invert(int[] array) {
    return Arrays.stream(array).map(x -> -x).toArray();
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(invert(new int[] { 1, 2, -3, 4, 5 })));
    System.out.println(Arrays.toString(invert(new int[] {})));

  }
}