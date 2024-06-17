// if input has square root, square root it, otherwise double it

import java.util.Arrays;

public class toSquareRootOrNot {
  public static int[] squareOrSquareRoot(int[] arr) {
    return Arrays.stream(arr).map(x -> {
      if (Math.sqrt(x) == Math.floor(Math.sqrt(x))) {
        return (int) Math.sqrt(x);
      } else
        return x * x;
    }).toArray();
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(squareOrSquareRoot(new int[] { 4, 3, 9, 7, 2, 1 })));
  }
}